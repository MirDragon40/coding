using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test22 : MonoBehaviour
{
    public int N;

    void Start()
    {
        string str1 = "";

        for (int i = 1; i <= N; i++)
        {

            str1 += "*";
            Debug.Log(str1);

        }



        for (int i = N; i > 0; i--)
        {
            string str2 = "";

            for (int j = N; j >= 1 ; j--)
            {


                if (j < i)
                {
                    str2 += "*";
                }
                else
                {
                    continue;
                }


                
            }

            Debug.Log(str2);

        }

    }

}


