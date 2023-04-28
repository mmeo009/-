using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    public Vector3 launchDirection;
    //발사 방향 벡터 선언
    public GameObject Projectile;
    //발사체 프리맵 선언
    public bool lOrR = true;
    public void FireProjectile()
        //발사체 함수 선언
    {
        GameObject temp = (GameObject)Instantiate(Projectile);
        //발사체 프리맵을 생성 시키고 temp에 입력
        //Instantiate 함수는 GameObject 프리맵을 생성 시킨다.

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
        //10초후에 발사체가 사라진다.


    }


}
