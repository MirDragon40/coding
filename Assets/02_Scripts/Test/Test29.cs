using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test29 : MonoBehaviour
{
    // �ٽ� Ǯ��, ��Ʈ �����
    public int[] A;

    void Start()
    {
        int count = A.Length;
        int[] a = new int[count];

        for (int i =0  ; i < count; i++ )
        {
            a[i] = A[i];
        }


        for (int i = 0; i < count; i++)
        {
            A[count- i -1] = a[i];
        }

        for (int i = 0; i < count; i++)
        {
            Debug.Log(A[i]);
        }

    }

}
