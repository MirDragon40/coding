using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test27_2 : MonoBehaviour
{
    void Start()
    {
        int[] A = { 3, 29, 38, 12, 57, 75, 40, 85, 61 };

        // ���� ū ���� ������ ���� (�⺻���� 0)
        int maxMumber = 0;
        int maxIndex = 0;
        for (int i = 0; i < A.Length; i++)
        {
            // 1. ���� ��ġ�� �ִ� �迭 ���� �����´�.
            int number = A[i];

            // 2. ���� ���� maxNumber ���� ũ�� ��ü�Ѵ�.
            if (number > maxMumber)
            {
                // ���� ū �� ��ü
                maxMumber = number;
                // ���� ū ���� �ִ� ��ġ�� ��ü
                maxIndex = i;
            }
        }

        Debug.Log(maxMumber);
        Debug.Log(maxIndex + 1);

    }

}
