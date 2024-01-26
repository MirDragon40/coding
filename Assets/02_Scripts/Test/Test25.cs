using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test25 : MonoBehaviour
{
    public int[] A;

    void Start()
    {
        
        int max2 = A[0];
        int min2 = A[0];
        int count = A.Length;

        for (int i = 1; i < count; i++)
        {
  

            if (max2 < A[i])
            {
                max2 = A[i];
            }
            
            
        }
        
        for (int i = 1; i < count; i++)
        {

            if (min2 > A[i])
            {
                min2 = A[i];
            }


        }
        Debug.Log($"{min2} {max2}");
    }

}
