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

        // ���� �ð����� �Ѿ��
        int overHour = C / 60;
        int overMin = C % 60;

        //���� �ð����� �Ѿ�� & �丮 ���� �ð� 23�ø� �Ѿ��
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

        // Min�� ������ �� �ѽð��� �ѱ涧
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

// ������ �ڵ�

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

//        // ���� ���� 60�к��� ���ų� ũ��
//        if (newMin >= 60)
//        {
//            newHour += (newMin / 60);  // �ð��� �����ְ�
//            newMin = (newMin % 60);    // ���� ������
//        }

//        if (newHour >= 24)
//        {
//            newHour -= 24;
//        }

//        Debug.Log($"{newHour} {newMin}");
//    }
// }