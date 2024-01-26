using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_0109 : MonoBehaviour
{
    // Q1. 정수 2개를 매개변수로 넘겨받아 두 수중 더 큰 수를 반환하는 함수를 만들고 테스트
    int MaxNums(int num1, int num2)    // 선언부분
    {
        //int Max = 0;
        //if (num1 > num2)
        //{
        //    Max = num1;
        //}
        //if (num1 < num2)
        //{
        //    Max = num2;
        //}
        //return Max;


        if(num1 > num2)              // 구현부분
        {
            return num1;
        }

        return num2;
    }


    // Q2. 정수 3개를 매개변수로 넘겨받아 평균을 구해 반환하는 함수를 만들고 테스트 (평균은 소수점이 있음)
    float AverNums(int num1, int num2, int num3)   // 함수 이름은 항상 대문자로
    {
        return (float)(num1 + num2 + num3)/3;   // 리턴을 하는 값이 float - 실수형이므로 함수이름 앞 형식을
                                                // float이라고 적어준다.
    }

    // Q3. 정수 1개를 매개변수로 넘겨받아 0부터 해당 정수값까지 출력해주는 함수를 만들고 테스트 (반환안함)
    void LogNums(int num1)
    {
        for (int i= 0; i <= num1; i++)
        {
            Debug.Log(i);
        }
    }

    void Start()
    {

        // 호출: 함수이름(매개변수);
        Debug.Log(4);


        int result = MaxNums(34, 23);

        Debug.Log(MaxNums(15, 45));

        Debug.Log(AverNums(133, 425, 23));

        LogNums(35);

        Debug.Log(Mathf.Max(6,4));

    }
}
