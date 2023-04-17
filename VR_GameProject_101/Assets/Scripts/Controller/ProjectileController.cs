using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    public GameObject Projectile;       //�߻�ü ������ ����

    //�߻�ü�� ���� �� �̵� ���͸� �־��༭ �߻��̵��� 10���� �Ҹ�
    public void FireProjectile()
    {
        //Instantiate �Լ��� ������Ʈ �� ������ �����ϴ� �Լ� 
        GameObject temp = (GameObject)Instantiate(Projectile);
        //������ Projectile�� temp�� �Է� 

        //�ش� ���ӿ�����Ʈ ��ġ���� ����
        temp.transform.position = this.gameObject.transform.position;
        
        //�߻�ü�� �߻� ������ �� ������Ʈ�� �������� �����Ѵ�. 
        temp.GetComponent<ProjectileMove>().launchDirection = transform.forward;

        //Destroy�� ���� ������Ʈ�� �����ִ� �Լ� (10���� �Ҹ�)
        Destroy(temp, 10.0f);
    }
}
