using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_002 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        int answer;
        answer = 1 + 2;
        Debug.Log(answer);

        int n1 = 8;
        int n2 = 9;
               
        Debug.Log(n1 + n2);    //이건 궁금해서 써본 테스트 (아래 코드의 결과와 같은 결과가 도출됨)

        int answer2;
        answer2 = n1 + n2;
        Debug.Log(answer2);    //answer2 값을 출력

        int answer3 = 10;
        answer3 += 5;          //정수 answer3에 +5값을 추가 =(answer3 = answer3 + 5)
        Debug.Log(answer3);

        answer3++;             //정수 answer3에 +1값을 추가
        Debug.Log(answer3);

        string str1 = "Happy ";
        string str2 = "Birthday";

        string str1_2 = str1 + str2;
        Debug.Log(str1_2);

        str1 += str2;
        Debug.Log(str1);

        string message = str1 + answer3;
        Debug.Log(message);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
