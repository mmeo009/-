using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleTileMap : MonoBehaviour
{
    public GameObject tile;
    //Ÿ�� ���� ������Ʈ ����

    void Start()
    {
        for(int i = 0; i < 10; i ++)
        {
            for(int j = 0; j < 10; j ++)
            {
                GameObject temp = (GameObject)Instantiate(tile);
                //Prefabs or Object�� Instantiate �Լ��� �����ϰ� temp�� �Է�
                temp.transform.position = new Vector3(i, 0, j);
                //������ Ÿ��(tile)�� ���ϴ� ��ġ�� ��ġ�Ѵ�.
            }
        }
    }

}
