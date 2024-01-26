using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class StaticTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //MyStudent.Number = 13; // 클래스 자체에 소속 (클래스.변수명)

        //MyStudent example = new MyStudent();
        //// example.Number = 13;
        //example.Age = 10;



        MyStudent student1 = new MyStudent("전민성", 11);
        MyStudent student2 = new MyStudent("이성민", 22);
        MyStudent student3 = new MyStudent("김예은", 33);

        // student1.Hello();  // -> 이렇게 접근하는 것이 아니라 
        MyStudent.Hello();    // -> 이렇게 접근해주어야 한다.

        Debug.Log($"나의 학생 수: {MyStudent.GetNumber()}명");   // MyStudent 에서 함수를 호출하여,값을 받아오면 된다. 
        // 학생수는 MyStudent.Number로 접근 가능


        // static은 유틸리티 관련 함수를 만들거나 사용할 때 유용하다.
        // 유틸리티 함수란: 게임 개발 중 반복적으로 사용되는 유용하고 실용적인 함수
        // stfing(문자열), Mathf(수학), Vector2(벡터), 디버그(Debug)
        string.Format("{0}", 1);
        Mathf.Max(1, 2, 3, 43);
        Vector2 dir = Vector2.up;
        Debug.Log(123);

        // 이유 
        // 1. 접근성:
        // 어디에서나 복잡한 객체 생성없이 클래스 이름만으로 접근할 수 있어서 쉽게 사용할 수 있다.

        // 2. 리소스(메모리) 절약:
        // 클래스의 객체를 생성할 필요가 없으므로 메모리 사용량을 줄일 수 있다.
        // 즉, 반복적으로 사용되는 유틸리티 함수에 있어서 효율적이다.

        // 3. 상태(속성) 독립성: -> 가장 중요
        // 일반적으로 유틸리티 함수는 속성(상태)을 유지할 필요가 없다. 객체의 멤버에 의존하지 않으므로
        // 입력에 대해서만 동작한다.


    }

}
