using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    string title = "������";
    string playerName = "�ź���";
    int level = 5;
    float strenght = 15.5f;
    int exp = 1500;
    int health = 30;
    int mana = 25;
    bool isFullLevel = true;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello Unity");

        //1.����
       

        //2.�׷��� ����
        string[] monsters = { "������", "�縷��", "�Ǹ�" };
        int[] monsterLevel = new int[3];
        monsterLevel[0] = 1;
        monsterLevel[1] = 6;
        monsterLevel[2] = 20;

        List<string> items = new List<string>();
        items.Add("������30");
        items.Add("��������30");

        //3.������

        exp = 1500 + 320;
        exp = exp - 10;
        level = exp / 300;
        strenght = level * 3.1f;

        int nextExp = 300 - (exp % 300);        

        int fullLevel = 99;
        isFullLevel = level == fullLevel;
        bool isEndTutorial = level > 10;
        //bool isBadCondition = health <= 50 && mana <= 20;
        bool isBadCondition = health <= 50 || mana <= 20;

        string condition = isBadCondition ? "����" : "����";

        //4.Ű����
        //int float string bool new list

        //5.���ǹ�
        if (condition == "����")
        {
            Debug.Log("�÷��̾��� ���°� ���ڴ� �������� ����ϼ���.");
        }
        else
        {
            Debug.Log("�÷��̾��� ���°� �����ϴ�.");
        }

        if (isBadCondition && items[0] == "������30")
        {
            items.RemoveAt(0);
            health += 30;
            Debug.Log("�������� 30�� ����Ͽ����ϴ�.");
        }

        else if (isBadCondition && items[0] == "��������30")
        {
            items.RemoveAt(0);
            mana += 30;
            Debug.Log("�������� 30�� ����Ͽ����ϴ�.");
        }

        string monsterAlarm;
        switch (monsters[1])
        {
            case "������":
            case "�縷��":
                monsterAlarm = "���� ���Ͱ� ����!";
                break;
            case "�Ǹ�":
                monsterAlarm = "���� ���Ͱ� ����!";
                break;
            case "��":
                monsterAlarm = "���� ���Ͱ� ����!";
                break;
            default:
                monsterAlarm = "??? ���Ͱ� ����!";
                break;
        }

        //6.�ݺ���
        while (health > 0)
        {
            health--;
            if (health > 0)
                Debug.Log("�� �������� �Ծ����ϴ�. " + health);
            else
                Debug.Log("����Ͽ����ϴ�");

            if (health == 10)
            {
                Debug.Log("�ص����� ����մϴ�.");
                break;
            }
        }

        for (int count = 0; count < 10; count++)
        {
            health++;
        }

        for (int index = 0; index < monsters.Length; index++)
        {
            //Debug.Log("�� ������ �ִ� ���� : " + monsters[index]);
        }

        foreach (string monster in monsters)
        {
            //Debug.Log("�� ������ �ִ� ���� : " + monsters);
        }

        //7.�Լ� (�޼ҵ�)
        Heal();

        for (int index = 0; index < monsters.Length; index++)
        {
            Debug.Log("���� " + monsters[index] + "���� " +
                Battle(monsterLevel[index]));
        }

        //8.Ŭ����
        player player = new player();
        player.id = 0;
        player.name = "������";
        player.title = "������";
        player.strength = 2.4f;
        player.weapon = "���� ������";
        Debug.Log(player.Talk());
        Debug.Log(player.HasWeapon());

        player.LevelUp();
        Debug.Log(player.name + "�� ������ " + player.level + " �Դϴ�.");
        Debug.Log(player.move());
    }


    //7.�Լ� (�޼ҵ�)
    void Heal()
    {
        health += 10;
        Debug.Log("���� �޾ҽ��ϴ� " + health);
    }

    string Battle(int monsterLevel)
    {
        string result;
        if (level >= monsterLevel)
            result = "�̰���ϴ�.";
        else
            result = "�����ϴ�.";

        return result;
    }
}
