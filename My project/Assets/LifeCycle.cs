using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    //�ʱ�ȭ
    
    //Awake : ���� ������Ʈ ������ ��, ���� ����
    void Awake()
    {
        Debug.Log("�÷��̾� �����Ͱ� �غ�Ǿ����ϴ�.");
    }

    //Ȱ��ȭ

    //OnEnable : ���� ������Ʈ�� Ȱ��ȭ �Ǿ��� ��
    void OnEnable()
    {
        Debug.Log("�÷��̾ �α����߽��ϴ�.");
    }

    //Start : ������Ʈ ���� ����, ���� ����
    void Start()
    {
        Debug.Log("��� ��� ì����ϴ�.");
    }
    
    //����

    //FixedUpdate : ���� ���� ������Ʈ(������ ���� �ֱ�� cpu�� ���� ���)
    void FixedUpdate()
    {
        Debug.Log("�̵�~");
    }

    //���� ����

    //Update : ���� ���� ������Ʈ
    void Update()
    {
        Debug.Log("���� ���!!");
    }

    //LateUpdate : ��� ������Ʈ ���� ��   
    void LateUpdate()
    {
        Debug.Log("����ġ ȹ��");
    }

    //��Ȱ��ȭ

    //OnDisable
    void OnDisable()
    {
        Debug.Log("�÷��̾ �α׾ƿ��߽��ϴ�.");
    }

    //��ü

    //OnDestroy : ���� ������Ʈ�� ������ ��
    void OnDestroy()
    {
        Debug.Log("�÷��̾� �����͸� �����Ͽ����ϴ�.");
    }
}
