using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test14 : MonoBehaviour
{
    public int n1;
    void Start()
    {
        int sum = 0;
        for (int i = 1; i <= n1; i++ )
        {
            sum += i;
        }
        Debug.Log(sum);
    }

}
