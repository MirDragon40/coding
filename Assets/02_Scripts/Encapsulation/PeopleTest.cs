using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        People people = new People("정수빈",25, 180.1f, "ENFP");
        people.SetAge(26);
        people.SetAge(-3);

        people.Height = -10;          // 프로퍼티 set 접근자 사용
        Debug.Log(people.Height);     // 프로퍼티 get 접근자 사용


        people.MBTI = "AAA"; // 실습. MBTI에 대해서 프로퍼티를 적용해보세요.




        // people.GetAge = -3; // 무결성이 깨졌다!
        // 무결성이란 데이터의 정확성, 일관성, 유효성

        Debug.Log(people.GetName());    // Setname을 안만듦으로써 외부에서 수정을 못하도록 할 수가 있다.
        Debug.Log(people.GetAge());

    }

}
