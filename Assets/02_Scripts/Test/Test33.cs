using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test33 : MonoBehaviour
{

    public string A;

    void Start()
    {
        int sum = 0;
        for (int i = 0; i < A.Length; i++)
        {
            

            if ( A[i] == ' ')
            {
                sum++;
            }
        }
        Debug.Log(sum + 1);
    }

}
