using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_001 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        int age;                //변수 age 선언
        age = 30;               //변수 age에 값입력
        Debug.Log(age);         //age에 입력된 값 출력
        
        float height1 = 160.5f;
        float height2;
        height2 = height1;      //초록색 물결 => 변수가 선언되었으나 사용되지 않음
        Debug.Log(height2);     //왼쪽값 = 오른쪽값 => 왼쪽값을 오른쪽 값으로 바꿈

        string name;
        name = "Sera";
        Debug.Log(name);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
