using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    //초기화
    
    //Awake : 게임 오브젝트 생성할 때, 최초 실행
    void Awake()
    {
        Debug.Log("플레이어 데이터가 준비되었습니다.");
    }

    //활성화

    //OnEnable : 게임 오브젝트가 활성화 되었을 떄
    void OnEnable()
    {
        Debug.Log("플레이어가 로그인했습니다.");
    }

    //Start : 업데이트 시작 직전, 최초 실행
    void Start()
    {
        Debug.Log("사냥 장비를 챙겼습니다.");
    }
    
    //물리

    //FixedUpdate : 물리 연산 업데이트(고정된 실행 주기로 cpu를 많이 사용)
    void FixedUpdate()
    {
        Debug.Log("이동~");
    }

    //게임 로직

    //Update : 게임 로직 업데이트
    void Update()
    {
        Debug.Log("몬스터 사냥!!");
    }

    //LateUpdate : 모든 업데이트 끝난 후   
    void LateUpdate()
    {
        Debug.Log("경험치 획득");
    }

    //비활성화

    //OnDisable
    void OnDisable()
    {
        Debug.Log("플레이어가 로그아웃했습니다.");
    }

    //해체

    //OnDestroy : 게임 오브젝트가 삭제될 때
    void OnDestroy()
    {
        Debug.Log("플레이어 데이터를 해제하였습니다.");
    }
}
