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
               
        Debug.Log(n1 + n2);    //�̰� �ñ��ؼ� �ẻ �׽�Ʈ (�Ʒ� �ڵ��� ����� ���� ����� �����)

        int answer2;
        answer2 = n1 + n2;
        Debug.Log(answer2);    //answer2 ���� ���

        int answer3 = 10;
        answer3 += 5;          //���� answer3�� +5���� �߰� =(answer3 = answer3 + 5)
        Debug.Log(answer3);

        answer3++;             //���� answer3�� +1���� �߰�
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
