using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMove : MonoBehaviour
{
    public Vector3 launchDirection;

    private void OnCollisionEnter(Collision collision)
    {   //���� �浹�� �ı�
        if(collision.gameObject.tag == "Wall")
        {           
            Destroy(this.gameObject);
        }
        //���Ϳ� �浹��
        if (collision.gameObject.tag == "Monster")
        {
            //���Ϳ��� �������� �ְ� �������. 
            collision.gameObject.GetComponent<MonsterController>().Damanged(1);
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)         //Trigger �Լ� 
    {   //���� �浹�� �ı�
        if (other.gameObject.tag == "Wall")             //Name -> Tag �� ��ȯ 
        {
            Destroy(this.gameObject);
        }
        //���Ϳ� �浹��
        if (other.gameObject.tag == "Monster")
        {
            //���Ϳ��� �������� �ְ� �������. 
            other.gameObject.GetComponent<MonsterController>().Damanged(1);
            Destroy(this.gameObject);
        }
    }

    private void FixedUpdate()
    {
        //�ð���� �̵� �� float ������ ����
        float moveAmount = 3 * Time.fixedDeltaTime;
        //launchDirection �������� �߻�ü �̵� (Translate) �̵� ��Ű�� �Լ�
        transform.Translate(launchDirection * moveAmount);
    }
}
