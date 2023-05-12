using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 5.0f;
    public float rotationSpeed = 1.0f;
    //��ž�� ȸ�� �ӵ� ����

    public GameObject bulletPrefab;
    public GameObject enemyPivot;

    public Transform firePoint;
    public float fireRate = 1.0f;
    public float nextFireTime;

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
        if (player != null)
        {
            if (Vector3.Distance(player.position, transform.position) > 5)
            //Vecter3.Distance (�Ÿ��� �˷��ִ� �Լ�)
            {
                Vector3 direction = (player.position - transform.position).normalized;
                //�� ���͸� ���� Normalized �ϸ� ���Ⱚ�� �˷���
                rb.MovePosition(transform.position + direction * speed * Time.deltaTime);
                //�÷��̾ ���ؼ� ������ speed�� �̵�
            }

            //��ž ȸ��

            Vector3 targetDiraction = (player.position - enemyPivot.transform.position).normalized;
            //�� ���͸� ���� Normalized �ϸ� ���Ⱚ�� �˷���
            Quaternion targetRotation = Quaternion.LookRotation(targetDiraction);
            //
            enemyPivot.transform.rotation = Quaternion.Lerp(enemyPivot.transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

            if (Time.time > nextFireTime)
            {
                nextFireTime = Time.time + 1.0f / fireRate;
                GameObject temp = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
                temp.GetComponent<ProjectileMove>().launchDirection = firePoint.localRotation * Vector3.forward;
                temp.GetComponent<ProjectileMove>().bulletType = ProjectileMove.BULLETTYPE.ENEMY;
            }
        }
    }
}
