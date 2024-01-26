using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Example17 : MonoBehaviour
{

    public string Id;
    public string Passward;
    

    const string ID = "Teemo";
    const string PASSWARD = "1234";


    void Start()
    {
        // 1. ID가 다르면 "존재하지 않는 ID 입니다."
        // 2. ID는 같으나 비밀번호가 다르면 "비밀번호가 틀렸습니다."
        // 3. ID와 비밀번호가 모두 같으면 출력: "로그인 됐습니다."


        bool result1 = Id == ID;
        if (result1 == false)
        {
            Debug.Log("존재하지 않는 ID 입니다.");
        }

        bool result2 = Passward == PASSWARD;
        if (result1 == true && result2 == false)
        {
            Debug.Log("비밀번호가 틀렸습니다.");
        }

        if (result1 == true && result2 == true)
        {
            Debug.Log("로그인 됐습니다.");
        }

        // 강사님 풀이
        if (Id != ID)
        {
            Debug.Log("존재하지 않는 ID입니다.");
        }
        if (Id == ID && Passward != PASSWARD)
        {
            Debug.Log("비밀번호가 틀렸습니다.");
        }

        if (Id == ID && Passward == PASSWARD)
        {
            Debug.Log("로그인 됐습니다.");
        }

        // 중첩조건문: 조건문 안에 또 다른 조건문이 들어가 있는 형태
        // 이중조건문, 삼중조건문도 가능함. but 이중조건문 까지만 허용
        // 3중 조건문이 되면 '내가 뭔가 잘못하고 있지 않을까?' 생각해보기

        if (Id != ID)
        {
            Debug.Log("존재하지 않는 ID입니다.");
        }
        else
        {
            if (Id == ID && Passward != PASSWARD)
            {
                Debug.Log("비밀번호가 틀렸습니다.");
            }

            else  // (Id == ID && Passward == PASSWARD)
            {
                Debug.Log("로그인 됐습니다.");
            }
        }
    }

}
