using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test26 : MonoBehaviour
{
    public int[] A;
    

    void Start()
    {
        int sum = 0;
        int count = A.Length;
        for (int i = 0; i < count; i++)
        {
            sum += A[i];
        }
        // float ������ int��  float��.
        float div = (float) sum / count;
        Debug.Log(div);


    }

}
