using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleTileMap : MonoBehaviour
{
    public GameObject tile_001;                                                         //������ �������� ����Ƽ �ν����� â���� �Է� �޴´�. 
    public GameObject tile_002;                                                         //������ �������� ����Ƽ �ν����� â���� �Է� �޴´�. 

    void Start()
    {
        for(int i = 0; i < 20; i++)
        {
            for(int j = 0; j < 10; j++)
            {
                GameObject temp = (GameObject)Instantiate(tile_001);                    //instantiate �Լ��� Prefabs�� �����ϴ� �Լ� return �ִ�. (temp�� �Է�)
                temp.transform.position = new Vector3(i, 0, j);                         //temp �Է¹��� ������Ʈ�� ��ġ ���� (x => i �̰� z => j) �̴�. 
            }

            for (int j = 10; j < 20; j++)
            {
                GameObject temp = (GameObject)Instantiate(tile_002);                    //instantiate �Լ��� Prefabs�� �����ϴ� �Լ� return �ִ�. (temp�� �Է�)
                temp.transform.position = new Vector3(i, 0, j);                         //temp �Է¹��� ������Ʈ�� ��ġ ���� (x => i �̰� z => j) �̴�. 
            }
        }
    }

   
}
