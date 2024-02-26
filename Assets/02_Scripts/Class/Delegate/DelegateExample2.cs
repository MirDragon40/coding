using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using System.Linq;

public class DelegateExample2 : MonoBehaviour
{

    void Start()
    {
        int[] numbers = { -10, 20, -30, 4, -5 };

        // 사용 예시 1.
        // 대리자를 통해 메서드를 매개변수로 전달할 수 있다.

        // C#의 배열이나 컬렉션에는 데이터를 쉽게 가공할 수 있는 Linq 기능이 있다.
        // Linq란 데이터들에게 질문을 던지고 그 결과를 받아오는 기능.
        int count = numbers.Count(IsBiggerThanZero);
        Debug.Log(count);

    }
    private bool IsBiggerThanZero(int num)
    {
        return num > 0;   // true인 것들만 
    }

}