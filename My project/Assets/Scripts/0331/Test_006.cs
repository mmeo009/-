using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_006 : MonoBehaviour
{
    //�迭 5�� ������ �����ϰ� �̸��� array��� ��
    public int[] array = new int[5];
    public int[] points = { 83, 99, 53, 93, 15 };

    void Start()
    {
        //������ �迭�� ������ �Է�
      
        array[0] = 2;
        array[1] = 10;
        array[2] = 5;
        array[3] = 15;
        array[4] = 3;

        //for���� ���� consoleâ�� ��� array�迭 �ȿ� �ִ� 0~4���� ������ ǥ��

        for(int i = 0; i < 5; i++)
        {

            Debug.Log(array[i]);

        }

        Debug.Log("=========================================");

        //�迭�� ���̸� �������� ����(�迭�̸�.Length)

        for(int i = 0; i < points.Length; i++)
        {
            if (points[i] > 90)
            {
                Debug.Log(points[i]);
            }
        }

        //���� ���ϱ� ���� �ӽ������� sum���� ����

        int sum = 0;

        //����� �迭�� �� ��

        for(int i = 0; i < points.Length; i++)
        {
            sum += points[i];
        }

        //������ �迭 ���� ��ŭ ����(��հ�)

        int average = sum / points.Length;

        //��հ� ���

        Debug.Log(average);

    }

    void Update()
    {
        
    }
}
