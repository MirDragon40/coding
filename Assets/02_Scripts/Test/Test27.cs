using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test27 : MonoBehaviour
{
    // 27¹ø ÃÖ´ñ°ª

    public int[] A;


    void Start()
    {
        int score = A.Length;
        int Max = 0;
        int Num = 0;

        for (int i = 0; i < score; i++ )
        {
            

            if (A[i] > Max )
            {
                Max = A[i];
                Num = i+1;
            }
        }
        Debug.Log(Max);
        Debug.Log(Num);

        
    }

}
