using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_007 : MonoBehaviour
{

    // �μ��� ��ȯ���� ���� �޼���
    void SayHello()
    {
        Debug.Log("===================");
        Debug.Log("Hello");
        Debug.Log("===================");
    }

    //�μ��� �ִ� �޼���
    void CallName(string name)
    {
        Debug.Log("Hello " + name);
    }
    //�μ��� ��ȯ���� �ִ� �޼���
    int Add(int a, int b)
    {
        //int�Լ��� �����߱� ������ return�� int���� ��

        int c = a + b;
        return c;
    }
    void Start()
    {
        SayHello();
        SayHello();
        SayHello();

        CallName("Tom");
        CallName("Harry");
        CallName("Lora");

        //���� answer����
        //�޼��� �� ȣ���Ͽ� 2,3�� ���� �Է� ���� return���� answer�� �Է�
        int answer;
        answer = Add(2, 3);
        Debug.Log(answer);
        //�Լ��� ������ ���� �ʰ� Debug.Log�� �μ��� ��� ����
        Debug.Log(Add(7, 9)); 

    }

}
