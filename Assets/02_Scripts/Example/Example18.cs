using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example18 : MonoBehaviour
{

    void Start()
    {
        // 2. 분기문: 조건이 아니라 값에 따라 분기(실행할 코드의 영역)을 나눌 수 있다.
        // switch - case
        /**
         switch (검사할 변수(값))
        {
            case 값1
            {
                변수의 값이 값 1일때 실행할 코드들
                break;값
            }
            case 값2
            {
                
            }
        }
         **/
        // 선택한 주문 번호에 따라 다른 음료수를 출력
        // 1번 선택: 콜라
        // 2번 선택: 사이타
        // 3번 선택: 닥터페퍼
        // 그 외: 물

        int orderNumber = 3;

        switch(orderNumber)
        {
            case 1:
            {
                    Debug.Log("콜라");
                    break;
            }

            case 2:
            {
                    Debug.Log("사이다");
                    break;
            }

            case 3:
                {
                    Debug.Log("닥터페퍼");
                    break;
                }
            default:
                {
                    Debug.Log("물");
                    break;
                }

        }
    }

   
}
