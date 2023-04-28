using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastController : MonoBehaviour
{
    public GameObject Monster;
    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            Ray cast = Camera.main.ScreenPointToRay(Input.mousePosition);
            //화면에서의 2차원 마우스 

            RaycastHit hit;

            if(Physics.Raycast(cast, out hit))
                //Rast가 충돌된것을 hit로 돌려준다.
            {
                if (hit.collider.tag == "Ground")
                {
                    GameObject temp = (GameObject)Instantiate(Monster);
                    temp.transform.position = hit.point + new Vector3(0.0f, 1.0f, 0.0f);
                }

                Debug.Log(hit.collider.name);
                //오브젝트 이름 출력

                Debug.DrawLine(cast.origin, hit.point, Color.red, 2.0f);
                //화면에 레이를 보여줌
            }
        }
    }
}
