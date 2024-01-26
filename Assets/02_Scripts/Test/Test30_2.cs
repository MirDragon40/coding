using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test30_2 : MonoBehaviour
{


    void Start()
    {
        int[] A = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        // ������ ���� üũ�ϱ� ���� �迭
        bool[] checks = new bool[42];

        // 1. �迭 A�� ��� ���� Ȯ���ϰ� �ʹ�. 
        for (int i = 0; i < A.Length; i++)
        {
            // 2. �� ����� ���� 42�� ���� ������ �� Ȯ��
            // Debug.Log(A[i]%42);
            checks[A[i] % 42] = true;
        }

        // ���� �ٸ� �������� �� �� �ִ��� ����Ѵ�.
        int count = 0;
        // 3. checks �迭����  true ������ ���Ѵ�.
        foreach(bool check in checks)
        {
            if(check == true)
            {
                count++;
            }
        }

        Debug.Log(count);
    }

}
