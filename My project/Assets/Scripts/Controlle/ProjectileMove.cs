using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;

public class ProjectileMove : MonoBehaviour
{
    public Vector3 launchDirection;

    public enum BULLETTYPE
    {
        PLAYER,
        ENEMY
    }
    //�߻�ü ���⼺ ����

    public BULLETTYPE bulletType = BULLETTYPE.PLAYER;

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

        if (collision.gameObject.tag == "Wall")
        {
            GameObject temp = this.gameObject;
            Destroy(temp);
            //�Ѿ��� �浹�ϸ� ����
        }
        if (collision.gameObject.tag == "Monster" && bulletType == BULLETTYPE.PLAYER)
        {
            collision.gameObject.GetComponent<MonsterController>().Monster_Damaged(1);
            GameObject temp = this.gameObject;
            Destroy(temp);
        }
        if (collision.gameObject.tag == "Player" && bulletType == BULLETTYPE.ENEMY)
        {
            collision.gameObject.GetComponent<PlayerController>().Player_Damaged(1);
            GameObject temp = this.gameObject;
            Destroy(temp);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "wall")
        {
            GameObject temp = this.gameObject;
            Destroy(temp);
        }
        //�Ѿ��� �浹�ϸ� ����
        if (other.gameObject.tag == "Monster" && bulletType == BULLETTYPE.PLAYER)
        {
            other.gameObject.GetComponent<MonsterController>().Monster_Damaged(1);
            other.gameObject.transform.DOPunchScale(new Vector3(0.5f, 0.5f, 0.5f), 0.1f, 10, 1);
            GameObject temp = this.gameObject;
            Destroy(temp);
        }
        if (other.gameObject.tag == "Player" && bulletType == BULLETTYPE.ENEMY)
        {
            other.gameObject.GetComponent<PlayerController>().Player_Damaged(1);
            GameObject temp = this.gameObject;
            Destroy(temp);
        }


    }

}
