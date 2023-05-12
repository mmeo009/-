using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 5.0f;
    public float rotationSpeed = 1.0f;
    //포탑의 회전 속도 변수

    public GameObject bulletPrefab;
    public GameObject enemyPivot;

    public Transform firePoint;
    public float fireRate = 1.0f;
    public float nextFireTime;

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
        if (player != null)
        {
            if (Vector3.Distance(player.position, transform.position) > 5)
            //Vecter3.Distance (거리를 알려주는 함수)
            {
                Vector3 direction = (player.position - transform.position).normalized;
                //두 벡터를 빼고 Normalized 하면 방향값을 알려줌
                rb.MovePosition(transform.position + direction * speed * Time.deltaTime);
                //플레이어를 향해서 설정한 speed로 이동
            }

            //포탑 회전

            Vector3 targetDiraction = (player.position - enemyPivot.transform.position).normalized;
            //두 벡터를 빼고 Normalized 하면 방향값을 알려줌
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
