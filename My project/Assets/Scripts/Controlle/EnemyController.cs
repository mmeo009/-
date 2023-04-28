using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 5.0f;

    private Rigidbody rb;
    private Transform player;
    //�÷��̾� ��ġ�� �������� ���� ����

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }


    void Update()
    {
        if(Vector3.Distance(player.position, transform.position) > 5)
            //Vecter3.Distance (�Ÿ��� �˷��ִ� �Լ�)
        {
            Vector3 direction = (player.position - transform.position).normalized;
            //�� ���͸� ���� Normalized �ϸ� ���Ⱚ�� �˷���
            rb.MovePosition(transform.position + direction * speed * Time.deltaTime);
            //�÷��̾ ���ؼ� ������ speed�� �̵�
        }
    }
}
