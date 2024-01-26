using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test21 : MonoBehaviour
{
    public int N;

    void Start()
    {
        for (int i = 1; i <= N; i++)
        {
            string a = "";

            for (int j = 0; j < N; j++)
            {
                if (j < N - i)
                {
                    a += "  ";
                }
                else
                {
                    a += "*";
                }

            }

            Debug.Log(a);
        }

        for (int i = N; i > 0; i--)
        {
            string b = "";

            for (int j = N ; j > 0; j-- )
            {
                if (j < i)
                {
                    b += "*";
                }
                else
                {
                    b += "  ";
                }
            }

            Debug.Log(b);

        }
    }

}
