using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class EnemyController : MonoBehaviour
{
    public float speed = 5.0f;              //적 속도

    public float rotationSpeed = 1f;        //포탑 회전 속도
    public GameObject bulletPrefab;         //총알 프리팹
    public GameObject EnemyPivot;           //적 피봇
    public Transform firePoint;             //발사 위치
    public float fireRate = 1f;             //연사 속도 
    public float nextFireTime;              //연사속도 시간 변수 

    private Rigidbody rb;                   //리지드 바디 선언
    private Transform player;               //플레이어 위치 선언

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();  //자기 자신의 리지드 바디 값 입력

        GameObject Temp = GameObject.FindGameObjectWithTag("Player");

        if(Temp != null)
        {
            player = Temp.transform;          //플레이어의 위치 값 입력
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        if(player != null)
        {
            if (Vector3.Distance(player.position, transform.position) > 5.0f)           //Vector3.Distance 거리 지원 함수
            {   //적 캐릭터 이동 
                Vector3 direction = (player.position - transform.position).normalized;          //플레이어와 나의 위치 백터를 뺄샘하여 방향 백터를 설정
                rb.MovePosition(transform.position + direction * speed * Time.deltaTime);       //적 이동 
            }

            //포탑 회전 
            Vector3 targetDirection = (player.position - EnemyPivot.transform.position).normalized; //플레이어와 적 피봇 백터를 뺄샘하여 방향 백터를 설정
            Quaternion targetRotation = Quaternion.LookRotation(targetDirection);                   //회전 값을 정해서 
            EnemyPivot.transform.rotation =
                Quaternion.Lerp(EnemyPivot.transform.rotation, targetRotation, rotationSpeed * Time.deltaTime); //회전 시켜주는 함수 

            //총알 발사
            if (Time.time > nextFireTime)
            {
                nextFireTime = Time.time + 1f / fireRate;
                GameObject temp = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
                temp.GetComponent<ProjectileMove>().launchDirection = firePoint.localRotation * Vector3.forward;
                temp.GetComponent<ProjectileMove>().projectileType = ProjectileMove.PROJECTILETYPE.ENEMY; //총알 타입 설정
            }
        }
       

    }
}
