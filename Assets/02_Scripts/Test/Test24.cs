using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test24 : MonoBehaviour
{
    public int[] N;
    public int X;

    void Start()
    {
        int count = N.Length;
        string a = "";
        for (int i = 0; i < count; i++)
        {
            

            if (N[i] < X)
            {
                a = a + $"{N[i]}  ";
            }
            else
            {
                continue;
            }
            
        }
        Debug.Log(a);
    }

}
