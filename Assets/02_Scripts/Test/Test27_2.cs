using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test27_2 : MonoBehaviour
{
    void Start()
    {
        int[] A = { 3, 29, 38, 12, 57, 75, 40, 85, 61 };

        // 가장 큰 값을 저장할 변수 (기본값은 0)
        int maxMumber = 0;
        int maxIndex = 0;
        for (int i = 0; i < A.Length; i++)
        {
            // 1. 현재 위치에 있는 배열 값을 가져온다.
            int number = A[i];

            // 2. 현재 값이 maxNumber 보다 크면 교체한다.
            if (number > maxMumber)
            {
                // 가장 큰 값 교체
                maxMumber = number;
                // 가장 큰 값이 있는 위치도 교체
                maxIndex = i;
            }
        }

        Debug.Log(maxMumber);
        Debug.Log(maxIndex + 1);

    }

}
