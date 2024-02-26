using System;
using UnityEngine;

public class FuncExample : MonoBehaviour
{
    void Start()
    {
        // Func<T1, T2, ... , TResult>
        // 입력: T 타입
        // 반환: TResult
        // 반드시 반환값이 있고, 매개 변수의 개수를 0~16개인 메서드를 담을 수 있는 대리자
        Func<int, bool> a = IsOdd;
        Debug.Log(a(17));

        // 람다표현식을 이용한 방식
        Func<int, bool> b = (num) =>
        {
            return num % 2 == 1;
        };   // 중괄호는 생략이 가능

        // 홀수 판별 함수
        bool IsOdd(int num)
        {
            return num % 2 == 1;
        }


    }
}