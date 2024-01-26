using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example35_1 : MonoBehaviour
{

    /**
     //반환 자료형이 없을 경우: void
    '반환 자료형' '함수 이름'('매개변수 목록')
       {
           // 실행할 코드를 
           // return 반환 데이터
       }
    **/


    // 1. 매개변수란: 함수를 호출(실행)할 때 전달되는 값. 매개변수는 지역변수이다.
    // 2. return이란:
    //      - return 이 호출되면 함수를 종료
    //      - 프로그램의 흐름을 호출자에 돌려준다.
    //      - 이때 특정 '반환 자료형'의 데이터를 반환한다.


    // Sum이라는 함수는 매개 변수 두개를 받아서 뭔가 처리 후 int  자료형의 데이터를 돌려주는 함수이다.
    int Sum(int num1, int num2)  // 함수 이름: 'Sum'  반환데이터: 'result' 반환 자료형: 'int'
    {
        int result = num1 + num2;
        return result;
        // return: 함수를 끝낸다(종료), 함수를 돌려준다(반환). return 아래에 적은 코드는 실행이 되지 않는다.

        // 위에서 return을 호출해 함수를 종료했으므로 아래 코드는 실행되지 않는다. 
        Debug.Log(1111111);
    }

    int Sub(int num1, int num2)
    {
        int result =  num1 - num2;
        return result;
    }


    int Mul(int num1, int num2)
    {
        int result = num1 * num2;
        return result;
    }

    int Div(int num1 , int num2)
    {
        int result = num1 / num2;
        return result;
    }

    void Start()
    {

        // 더하기 
        int result = Sum(436, 575);
        Debug.Log(result);

        // 빼기
        result = Sub(17, 9);
        Debug.Log(result);

        // 곱하기 
        result = Mul(22, 78);
        Debug.Log(result);

        // 나누기
        result = Div(102305, 55);
        Debug.Log(result);
    }

}
