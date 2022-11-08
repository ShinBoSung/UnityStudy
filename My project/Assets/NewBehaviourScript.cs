using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    string title = "전설의";
    string playerName = "신보성";
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

        //1.변수
       

        //2.그룹형 변수
        string[] monsters = { "슬라임", "사막뱀", "악마" };
        int[] monsterLevel = new int[3];
        monsterLevel[0] = 1;
        monsterLevel[1] = 6;
        monsterLevel[2] = 20;

        List<string> items = new List<string>();
        items.Add("생명물약30");
        items.Add("마나물약30");

        //3.연산자

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

        string condition = isBadCondition ? "나쁨" : "좋은";

        //4.키워드
        //int float string bool new list

        //5.조건문
        if (condition == "나쁨")
        {
            Debug.Log("플레이어의 상태가 나쁘니 아이템을 사용하세요.");
        }
        else
        {
            Debug.Log("플레이어의 상태가 좋습니다.");
        }

        if (isBadCondition && items[0] == "생명물약30")
        {
            items.RemoveAt(0);
            health += 30;
            Debug.Log("생명포션 30을 사용하였습니다.");
        }

        else if (isBadCondition && items[0] == "마나물약30")
        {
            items.RemoveAt(0);
            mana += 30;
            Debug.Log("마나포션 30을 사용하였습니다.");
        }

        string monsterAlarm;
        switch (monsters[1])
        {
            case "슬라임":
            case "사막뱀":
                monsterAlarm = "소형 몬스터가 출현!";
                break;
            case "악마":
                monsterAlarm = "중형 몬스터가 출현!";
                break;
            case "골렘":
                monsterAlarm = "대형 몬스터가 출현!";
                break;
            default:
                monsterAlarm = "??? 몬스터가 출현!";
                break;
        }

        //6.반복문
        while (health > 0)
        {
            health--;
            if (health > 0)
                Debug.Log("독 데미지를 입었습니다. " + health);
            else
                Debug.Log("사망하였습니다");

            if (health == 10)
            {
                Debug.Log("해독제를 사용합니다.");
                break;
            }
        }

        for (int count = 0; count < 10; count++)
        {
            health++;
        }

        for (int index = 0; index < monsters.Length; index++)
        {
            //Debug.Log("이 지역에 있는 몬스터 : " + monsters[index]);
        }

        foreach (string monster in monsters)
        {
            //Debug.Log("이 지역에 있는 몬스터 : " + monsters);
        }

        //7.함수 (메소드)
        Heal();

        for (int index = 0; index < monsters.Length; index++)
        {
            Debug.Log("용사는 " + monsters[index] + "에게 " +
                Battle(monsterLevel[index]));
        }

        //8.클래스
        player player = new player();
        player.id = 0;
        player.name = "나법사";
        player.title = "현명한";
        player.strength = 2.4f;
        player.weapon = "나무 지팡이";
        Debug.Log(player.Talk());
        Debug.Log(player.HasWeapon());

        player.LevelUp();
        Debug.Log(player.name + "의 레벨은 " + player.level + " 입니다.");
        Debug.Log(player.move());
    }


    //7.함수 (메소드)
    void Heal()
    {
        health += 10;
        Debug.Log("힐을 받았습니다 " + health);
    }

    string Battle(int monsterLevel)
    {
        string result;
        if (level >= monsterLevel)
            result = "이겼습니다.";
        else
            result = "졌습니다.";

        return result;
    }
}
