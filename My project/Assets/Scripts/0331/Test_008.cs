using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player
{
    private int hp = 100;
    private int Power = 50;

    //�޼ҵ� Attack ����
    public void Attack()
    {
        Debug.Log(this.Power + " �������� ������.");
    }

    //�޼ҵ� Damage ����
    public void Damage(int damage)
    {
        this.hp -= damage;
        Debug.Log(damage + " �������� �Ծ���.");
    }
    public int GetHp()
    {
        return hp;
    }
}

public class Test_008 : MonoBehaviour
{
    public Text playerHp;
    public Text playerHp2;

    Player mPlayer = new Player();
    Player mPlayer2 = new Player();

    void Start()
    {
        //Player �޼ҵ� Attack ȣ��
    //    mPlayer.Attack();
        //Player �޼ҵ� Damage ȣ��
    //    mPlayer.Damage(30);
        //Player Hp ������
    //    Debug.Log(mPlayer.GetHp());
    }

    void Update()
    {
        playerHp.text = "Player1 HP : " + mPlayer.GetHp().ToString();
        playerHp2.text = "Player2 HP : " + mPlayer2.GetHp().ToString();

        if (Input.GetMouseButtonDown(0))
        {
            mPlayer.Damage(1);
        }

        if(Input.GetMouseButtonDown(1))
        {
            mPlayer2.Damage(1);
        }
    }
}
