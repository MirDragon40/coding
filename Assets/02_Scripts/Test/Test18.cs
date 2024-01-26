using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test18 : MonoBehaviour
{


    void Start()
    {
        for (int j = 1; j <= 9; j++)
        {
            for (int i = 1; i <= 9; i++)
            {
                Debug.Log($"{j}*{i} = {j * i}");
            }
        }
        
    }
}
