using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherBall : MonoBehaviour
{
    MeshRenderer mesh;
    Material mat;

    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
    }

    //OnCollisionEnter : 물리적 충돌이 시작할 때 호출되는 함수.
    //Collision : 충돌 정보 클래스
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "My Ball")
            mat.color = new Color(0, 0, 0);

    }

    //OnCollisionStay : 물리적 충돌이 계속 일어날 때 호출되는 함수.
    /*
    private void OnCollisionStay(Collision collision)
    {

    }
    */

    //OnCollisionExit : 물리적 충돌이 끝났을 때 호출되는 함수.
    /*
    private void OnCollisionExit(Collision collision)
    {
        
    }
    */
    
}
