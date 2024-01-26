using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test16 : MonoBehaviour
{
    public int n;

    void Start()
    {
        int sum = 1;
        for (int i = n; i > 0; i--)
        {
            sum = sum*i;
            
        }
        Debug.Log(sum);
    }
}
