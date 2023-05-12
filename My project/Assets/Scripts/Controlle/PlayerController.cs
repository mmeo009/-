using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    //이동속도 변수 선언
    public GameObject PlayerPivot;
    //플레이어 피봇 선언
    Camera viewCamera;
    //카메라 정보를 가져오기 위해 선언
    Vector3 velocity;
    // 이동방향 벡터 값 선언
    public ProjectileController projectileController;
    //발사컨트롤 클래스 접근
    public float player_hp = 20;




    void Start()
    {
        viewCamera = Camera.main;
        // 주로 사용하는 카메라 입력
    }
    public void Player_Damaged(int damage)
    //데미지 받는 함수 (함수 int)
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
        //모니터 2D -> 인게임 3D 좌표로 변환 (마우스가 3D상에 어디에 있는지)

        Vector3 targetPosition = new Vector3(mousePos.x, transform.position.y, mousePos.z);
        //바라볼 위치를 계산하기 위해서 오브젝트 y축 좌표를 설정 (바닥은 x,z축)

        PlayerPivot.transform.LookAt(targetPosition, Vector3.up);
        //받아온 피봇이 마우스를 보게 한다.

        velocity = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxis("Vertical")).normalized * moveSpeed;
        //wasd나 화살표 이동 or 지원하는 이동입력 도구 (Horizontal, Vertical)

        if(Input.GetMouseButtonDown(0))
        {
            projectileController.FireProjectile();
        }
    }

    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + velocity * Time.fixedDeltaTime);
        //GetComponent 소스가 있는 게임 오브젝트에서 <> 안에 있는 컴퍼넌트에 접근
        //이후 계산된 위치의 값을 MovePosition 함수에 적용
    }


}
