using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRotation : MonoBehaviour
{

    float rotSpeed = 0; 
    //ȸ���ӵ� ����



    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            this.rotSpeed = 10000;
        }
        //���콺 ���� ��ư�� ������ ȸ������ 10000���� 


        transform.Rotate(0, this.rotSpeed * Time.deltaTime, 0);
        //transform�� ĳ���� ��ġ ���۳�Ʈ
        //Rotate�� ȸ���� �����ִ� �Լ�
        
        rotSpeed *= 0.99f;
        //�����Ӹ��� 1%�� ���� 


    }
}
