using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 target = new Vector3(8, 1.5f, 0);

    void Update()
    {
        //1.MoveTowards : 등속 이동

        /*
        transform.position =
            Vector3.MoveTowards(transform.position,
                                target, 0.01f);
        */

        //2.SmoothDamp : 부드러운 감속 이동

        /*
        Vector3 velo = Vector3.zero;

        transform.position =
            Vector3.SmoothDamp(transform.position,
                                target, ref velo, 1f); //ret : 참조 접근 -> 실시간으로 바뀌는 값 적용 가능
        */

        //3.Lerp : 선형 보간, SmoothDamp보다 감속시간이 김

        /*
        transform.position =
            Vector3.Lerp(transform.position,
                                target, 0.05f);
        */

        //4.Slerp : 구면 선형 보간, 호를 그리며 이동

        transform.position =
            Vector3.Slerp(transform.position,
                                target, 0.005f);

    }
}
