using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBall : MonoBehaviour
{
    Rigidbody rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //1.�ӷ� �ٲٱ�

        //rigid.velocity = vec;

        //2.���� ���ϱ�

        
        if (Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(Vector3.up * 25, ForceMode.Impulse);
        }
        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal"),
            0, Input.GetAxisRaw("Vertical"));

        rigid.AddForce(vec, ForceMode.Impulse);
        
        //3.ȸ����

        //rigid.AddTorque(Vector3.down);
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.name == "Cube" )
        {
            rigid.AddForce(Vector3.up * 10, ForceMode.Impulse);
        }        
    }

    public void Jump()
    {
        rigid.AddForce(Vector3.up * 20, ForceMode.Impulse);
    }
}
