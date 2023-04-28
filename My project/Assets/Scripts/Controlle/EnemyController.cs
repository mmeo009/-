using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 5.0f;

    private Rigidbody rb;
    private Transform player;
    //플레이어 위치를 가져오기 위해 선언

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }


    void Update()
    {
        if(Vector3.Distance(player.position, transform.position) > 5)
            //Vecter3.Distance (거리를 알려주는 함수)
        {
            Vector3 direction = (player.position - transform.position).normalized;
            //두 벡터를 빼고 Normalized 하면 방향값을 알려줌
            rb.MovePosition(transform.position + direction * speed * Time.deltaTime);
            //플레이어를 향해서 설정한 speed로 이동
        }
    }
}
