using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour
{

    public int monster_hp = 5;

    public void Monster_Damaged(int damage)
        //������ �޴� �Լ� (�Լ� int)
    {
        monster_hp -= damage;

        if(monster_hp <= 0)
        {
            GameObject temp = this.gameObject;
            Destroy(temp);
        }

    }

    private void Update()
    {
        if(transform.position.y <= -5)
        {
            Destroy(this.gameObject);
        }
    }

}
