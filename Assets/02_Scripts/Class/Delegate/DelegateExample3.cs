using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DelegateExample3 : MonoBehaviour
{
    private delegate void ExDelegate();
    // ExDelegate 라는 대리자 타입은 "void 이름()" 형태의 메서드를 참조할 수 있다.

    void Start()
    {
        // 델리게이트 멀티캐스트: 여러 개의 메서드를 담을 수 있다는 뜻.
        // 델리게이트 체인: 델리게이트가 참조하고 있는 여러 개의 메세드를 연결하여 연쇄적으로 호출하는것
        ExDelegate morningRotuine = WakeUp;
        morningRotuine += DrinkWater;
        morningRotuine += Shower;  // +=(덧셈 대입 연산자)를 이용해서 추가를 


        morningRotuine -= DrinkWater; // -=(뺄셈 대입 연산자)를 이용해서 빼기가 가능
        //morningRotuine -= WakeUp;
        //morningRotuine -= Shower;

        // 호출 방법 2가지
        // 1. () 가로 열고 닫고 문법
        // 2. Invoke()를 이용한 호출


        if (morningRotuine != null)    // 방어코드 (null 검사)
        {
            // morningRotuine();
            morningRotuine.Invoke();
        }

        morningRotuine?.Invoke();   // null이 아닐때만 호출. 교재 708p 참고. 나중에 익숙해질때 사용.
    }

    private void WakeUp()
    {
        Debug.Log("일어났다!");
    }
    private void DrinkWater()
    {
        Debug.Log("물마셨다!");
    }
    private void Shower()
    {
        Debug.Log("세수했다!");
    }
}
