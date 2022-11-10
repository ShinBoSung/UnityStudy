using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    //Translate : 벡터 값을 현재 위치에 더하는 함수
    
    void Start()
    {
        
        
    }

    //Time.deltaTime : 이전 프레임의 완료까지 걸린 시간
    //Time.deltaTime 값은 프레임이 적으면 크고 프레임이 많으면 작음

    void Update()
    {
        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal") * Time.deltaTime,
            Input.GetAxisRaw("Vertical") * Time.deltaTime,
            0); // 벡타 값
        transform.Translate(vec);
    }
}
