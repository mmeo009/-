using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMove : MonoBehaviour
{
    public Vector3 launchDirection;
    //�߻�ü ���⼺ ����

    private void FixedUpdate()
    {
        float moveAmount = 3 * Time.fixedDeltaTime;
        //�߻�ü �̵� �ӵ�
        transform.Translate(launchDirection * moveAmount);
        //�ش� �������� �̵�

    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);

        if (collision.gameObject.name != "Player")
        {
            GameObject temp = this.gameObject;
            Destroy(temp);
            //�Ѿ��� �浹�ϸ� ����

            if (collision.gameObject.name == "Monster")
            {
                collision.gameObject.GetComponent<MonsterController>().Monster_Damaged(1);
            }
        }
    }

}