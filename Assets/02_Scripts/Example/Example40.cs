using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example40 : MonoBehaviour
{
    void Start()
    {
        // 조건(삼향) 연산자
        // -> 조건식을 사용해서 조건식의 참, 거짓 여부에 따라 다른 결과값을 대입
        // 조건식 ? 조건식이 참일때의 값 :  조건식이 거짓일때의 값

        int number = 4;
        // Q. number가 짝수면 "짝수"라고 출력, 홀수면 "홀수"라고 출력

        /* 조건 연산자를 배우기 전 쓰던 방식
        if (number % 2 == 0)
        {
            Debug.Log("짝수");
        }
        else
        {
            Debug.Log("홀수");
        }
        */

        Debug.Log(number % 2 == 0 ? "짝수" : "홀수");

        int playerHealth = 100;
        int monsterDamage = 127;

        // 공격을 당했다.
        // Q. 공격을 당한 이후, 플레이어 체력이 0보다 작으면 0이 되도록 하고 싶다. 
        playerHealth = playerHealth - monsterDamage;
        if (playerHealth < 0)
        {
            playerHealth = 0;
        }
        playerHealth = Math.Max(playerHealth, 0);

        // A1. 조건문 이용 방식
        // A2. Math.Max 이용 방식
        // A3. 삼향연산자 이용 방식
        playerHealth = playerHealth > 0 ? playerHealth : 0;
    }

}
