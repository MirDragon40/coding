using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Unity.VisualScripting;
using UnityEngine;

public class Test43 : MonoBehaviour
{
    public int N;

    void Start()
    {

        for (int i = 1; i <= N; i++)
        {
            string all1 = "";

            for (int j = 1; j <= 2 * N - 1; j++)
            {
                if ( all1.Length > N - j-1 &&  all1.Length  < N + j-1)
                {
                    all1 += "*";
                }

                else
                {
                    all1 += " ";
                }

                if (j == 2 * N - 1)
                {
                    Debug.Log(all1);
                }


            }
        }

    }


}


