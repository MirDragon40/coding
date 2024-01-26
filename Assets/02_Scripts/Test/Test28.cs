using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Test28 : MonoBehaviour
{
    public int[] A;
    public int[] studentNum;

    void Start()
    {
        int count1 = A.Length;
        int count2 = studentNum.Length;


        // 规过1

        int[] s = new int[30];
        for (int i = 0; i < 3; ++i)
        {
            s[i] = 0;
        }


        for (int i = 0; i < count1; i++)
        {
            int num = A[i] - 1;
            s[num] = 1;
        }


        for (int i = 0; i < 30; ++i)
        {
            if (s[i] == 0)
            {
                Debug.Log(i + 1);
            }
        }



        // 规过2

        for (int i = 0; i < count2; i++)
        {
            int miss = 0;

            for (int j = 0; j < count1; j++)
            {

                if (A[j] == studentNum[i])
                {
                    miss = studentNum[i];
                }

            }

            if (miss == 0)
            {
                Debug.Log(studentNum[i]);
            }
        }
    }
}
