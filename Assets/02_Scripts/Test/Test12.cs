using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test12 : MonoBehaviour
{
    public int A;
    public int B;
    public int C;


    void Start()
    {

        // 다음 시간으로 넘어가는
        int overHour = C / 60;
        int overMin = C % 60;

        //다음 시간으로 넘어가기 & 요리 이후 시간 23시를 넘어갈때
        if (overHour >= 1 && overHour + A >= 23 && overMin < 60)
        {
            if (B + overMin > 60)
            {
                Debug.Log($"{(overHour + A) - 23}:{B + overMin - 60}");
            }
            else if (B + overMin < 60)
            {
                Debug.Log($"{(overHour + A) - 23}:{B + overMin}");
            }
            else
            {
                Debug.Log($"{(overHour + A + 1) - 23}:{B + overMin}");
            }


        }

        // Min을 더했을 때 한시간을 넘길때
        else if (overMin + B >= 60 && overHour + A < 23)
        {
            if (overMin + B == 60)
            {
                Debug.Log($"{A + 2}:{(overMin + B) - 60}");
            }
            else
            {
                Debug.Log($"{A + 1}:{(overMin + B) - 60}");
            }
        }
        else if (overMin + B >= 60 && overHour >= 1 && overHour + A >= 23)
        {
            Debug.Log($"{overHour + A + 1}:{overMin + B - 60}");
        }
        else if (overMin < 60 && overHour + A < 23)
        {
            Debug.Log($"{A + overHour}:{B + overMin}");
        }

        
    }
}

// 선생님 코드

//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Test12 : MonoBehaviour
// {
//    public int Hour = 14;
//    public int Min = 30;

//    public int AddMin = 20;

//    void Start()
//    {
//        int newHour = Hour;
//        int newMin = Min + AddMin;

//        // 만약 분이 60분보다 같거나 크면
//        if (newMin >= 60)
//        {
//            newHour += (newMin / 60);  // 시간은 더해주고
//            newMin = (newMin % 60);    // 분은 나머지
//        }

//        if (newHour >= 24)
//        {
//            newHour -= 24;
//        }

//        Debug.Log($"{newHour} {newMin}");
//    }
// }