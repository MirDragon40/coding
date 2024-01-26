using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test35 : MonoBehaviour
{
    public string A;

    void Start()
    {
        Debug.Log($"{A[0]}{A[A.Length - 1]}");
        
    }

 
}
