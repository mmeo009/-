using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_001 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        int age;                //���� age ����
        age = 30;               //���� age�� ���Է�
        Debug.Log(age);         //age�� �Էµ� �� ���
        
        float height1 = 160.5f;
        float height2;
        height2 = height1;      //�ʷϻ� ���� => ������ ����Ǿ����� ������ ����
        Debug.Log(height2);     //���ʰ� = �����ʰ� => ���ʰ��� ������ ������ �ٲ�

        string name;
        name = "Sera";
        Debug.Log(name);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
