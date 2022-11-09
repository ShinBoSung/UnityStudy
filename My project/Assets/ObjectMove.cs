using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    //Translate : 벡터 값을 현재 위치에 더하는 함수
    
    void Start()
    {
        
        
    }

    void Update()
    {
        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical"),
            0); // 벡타 값
        transform.Translate(vec);
    }
}
