using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_003 : MonoBehaviour
{

    public int herNum = 1;

    void Start()
    {
        if(herNum == 1)
        {
            Debug.Log("ü���� 50 ȸ��");
        }
        else
        {
            Debug.Log("ü�� - 50");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
