using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test10 : MonoBehaviour
{
    public int x;
    public int y;

    void Start()
    {
        if (x >= 0 && y >= 0)
        {
            Debug.Log("Quandrant1");
        }
        else if (x >= 0 && y <= 0)
        {
            Debug.Log("Quandrant4");
        }
        else if (x <= 0 && y <= 0)
        {
            Debug.Log("Quandrant3");
        }
        else if (x <= 0 && y >= 0)
        {
            Debug.Log("Quandrant2");
        }
    }

}
