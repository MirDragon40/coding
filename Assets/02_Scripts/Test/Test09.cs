using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Test09 : MonoBehaviour
{
    public int year;

    void Start()
    {
        int year_a = year % 4;
        int year_b = year % 100;
        int year_c = year % 400;

        if (year_a == 0)
        {
            Debug.Log("1");
        }
        else if (year_b == 0)
        {
            Debug.Log("0");
        }
        else if (year_a == 0 && year_b == 0)
        {
            Debug.Log("0");
        }
        else if (year_c == 0 && year_b == 0)
        {
            Debug.Log("1");
        }
        else
        {
            Debug.Log("0");
        }
    }
    
}
