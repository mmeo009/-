using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRotation : MonoBehaviour
{

    float rotSpeed = 0; 
    //회전속도 변수



    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            this.rotSpeed = 10000;
        }
        //마우스 왼쪽 버튼을 누르면 회전값을 10000으로 


        transform.Rotate(0, this.rotSpeed * Time.deltaTime, 0);
        //transform은 캐릭터 위치 컴퍼넌트
        //Rotate는 회전을 시켜주는 함수
        
        rotSpeed *= 0.99f;
        //프레임마다 1%씩 감소 


    }
}
