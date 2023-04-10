using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleTileMap : MonoBehaviour
{
    public GameObject tile_001;                                                         //생성할 프리팹을 유니티 인스팩터 창에서 입력 받는다. 
    public GameObject tile_002;                                                         //생성할 프리팹을 유니티 인스팩터 창에서 입력 받는다. 

    void Start()
    {
        for(int i = 0; i < 20; i++)
        {
            for(int j = 0; j < 10; j++)
            {
                GameObject temp = (GameObject)Instantiate(tile_001);                    //instantiate 함수는 Prefabs을 생성하는 함수 return 있다. (temp에 입력)
                temp.transform.position = new Vector3(i, 0, j);                         //temp 입력받은 오브젝트의 위치 값은 (x => i 이고 z => j) 이다. 
            }

            for (int j = 10; j < 20; j++)
            {
                GameObject temp = (GameObject)Instantiate(tile_002);                    //instantiate 함수는 Prefabs을 생성하는 함수 return 있다. (temp에 입력)
                temp.transform.position = new Vector3(i, 0, j);                         //temp 입력받은 오브젝트의 위치 값은 (x => i 이고 z => j) 이다. 
            }
        }
    }

   
}
