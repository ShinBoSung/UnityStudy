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

    //OnCollisionEnter : ������ �浹�� ������ �� ȣ��Ǵ� �Լ�.
    //Collision : �浹 ���� Ŭ����
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "My Ball")
            mat.color = new Color(0, 0, 0);

    }

    //OnCollisionStay : ������ �浹�� ��� �Ͼ �� ȣ��Ǵ� �Լ�.
    /*
    private void OnCollisionStay(Collision collision)
    {

    }
    */

    //OnCollisionExit : ������ �浹�� ������ �� ȣ��Ǵ� �Լ�.
    /*
    private void OnCollisionExit(Collision collision)
    {
        
    }
    */
    
}
