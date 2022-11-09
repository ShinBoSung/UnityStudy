﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyboard_mouse : MonoBehaviour
{
    //Input : 게임 내 입력을 관리하는 클래스

    void Update()
    {
        //anyKeyDown : 아무 입력을 최초로 받을 때 true

        if (Input.anyKeyDown)
            Debug.Log("플레이어가 아무 키를 눌렀습니다.");

        //anyKey : 아무 입력을 받으면 true

        /* if (Input.anyKey)
             Debug.Log("플레이어가 아무 키를 누르고 있습니다.");
        */

        //GetKey : 키보드 버튼 입력을 받으면 true

        if (Input.GetKeyDown(KeyCode.Return))
            Debug.Log("아이템을 구입하였습니다.");

        if (Input.GetKey(KeyCode.LeftArrow))
            Debug.Log("왼쪽으로 이동 중");

        if (Input.GetKeyUp(KeyCode.RightArrow))
            Debug.Log("오른쪽 이동을 멈추었습니다.");

        //GetMouse : 마우스 버튼 입력을 받으면 true

        if (Input.GetMouseButtonDown(0))
            Debug.Log("미사일 발사!");

        if (Input.GetMouseButton(0))
            Debug.Log("미사일 모으는 중...");

        if (Input.GetMouseButtonUp(0))
            Debug.Log("슈퍼 미사일 발사!!");

        //GetButton : Input 버튼 입력을 받으면 true

        if (Input.GetButtonDown("Jump"))
            Debug.Log("점프!");

        if (Input.GetButton("Jump"))
            Debug.Log("점프 모으는 중...");

        if (Input.GetButtonUp("Jump"))
            Debug.Log("슈퍼 점프!!");

        //GetAxis: 수평 수직 버튼 입력을 받으면 float

        /*
        if (Input.GetButton("Horizontal"))
        {
            Debug.Log("횡 이동 중..." + Input.GetAxis("Horizontal"));
            
        }
        */

        //오브젝트는 변수 transform을 항상 가지고 있음.

        if (Input.GetButton("Horizontal"))
        {
            Debug.Log("횡 이동 중..." + 
                Input.GetAxisRaw("Horizontal"));

        }

        if (Input.GetButton("Vertical"))
        {
            Debug.Log("종 이동 중..." +
                Input.GetAxisRaw("Vertical"));

        }
    }
}
