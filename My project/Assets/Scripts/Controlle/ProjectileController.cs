using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    public Vector3 launchDirection;
    //�߻� ���� ���� ����
    public GameObject Projectile;
    //�߻�ü ������ ����
    public bool lOrR = true;
    public void FireProjectile()
        //�߻�ü �Լ� ����
    {
        GameObject temp = (GameObject)Instantiate(Projectile);
        //�߻�ü �������� ���� ��Ű�� temp�� �Է�
        //Instantiate �Լ��� GameObject �������� ���� ��Ų��.

        if (lOrR == true)
        {
            temp.transform.position = this.gameObject.transform.position + new Vector3(0.5f, 0.0f, 0.0f);
            lOrR = false;
        }
        else
        {
            temp.transform.position = this.gameObject.transform.position + new Vector3(-0.4f, 0.0f, 0.0f);
            lOrR = true;
        }
        temp.GetComponent<ProjectileMove>().launchDirection = transform.forward;



        Destroy(temp, 10f);
        //10���Ŀ� �߻�ü�� �������.


    }


}
