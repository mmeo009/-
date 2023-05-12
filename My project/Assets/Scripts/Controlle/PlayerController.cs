using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    //�̵��ӵ� ���� ����
    public GameObject PlayerPivot;
    //�÷��̾� �Ǻ� ����
    Camera viewCamera;
    //ī�޶� ������ �������� ���� ����
    Vector3 velocity;
    // �̵����� ���� �� ����
    public ProjectileController projectileController;
    //�߻���Ʈ�� Ŭ���� ����
    public float player_hp = 20;




    void Start()
    {
        viewCamera = Camera.main;
        // �ַ� ����ϴ� ī�޶� �Է�
    }
    public void Player_Damaged(int damage)
    //������ �޴� �Լ� (�Լ� int)
    {
        player_hp -= damage;

        if (player_hp <= 0)
        {
            GameObject temp = this.gameObject;
            Destroy(temp);
        }

    }

    void Update()
    {       
        Vector3 mousePos = viewCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, viewCamera.transform.position.y));
        //����� 2D -> �ΰ��� 3D ��ǥ�� ��ȯ (���콺�� 3D�� ��� �ִ���)

        Vector3 targetPosition = new Vector3(mousePos.x, transform.position.y, mousePos.z);
        //�ٶ� ��ġ�� ����ϱ� ���ؼ� ������Ʈ y�� ��ǥ�� ���� (�ٴ��� x,z��)

        PlayerPivot.transform.LookAt(targetPosition, Vector3.up);
        //�޾ƿ� �Ǻ��� ���콺�� ���� �Ѵ�.

        velocity = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxis("Vertical")).normalized * moveSpeed;
        //wasd�� ȭ��ǥ �̵� or �����ϴ� �̵��Է� ���� (Horizontal, Vertical)

        if(Input.GetMouseButtonDown(0))
        {
            projectileController.FireProjectile();
        }
    }

    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + velocity * Time.fixedDeltaTime);
        //GetComponent �ҽ��� �ִ� ���� ������Ʈ���� <> �ȿ� �ִ� ���۳�Ʈ�� ����
        //���� ���� ��ġ�� ���� MovePosition �Լ��� ����
    }


}
