using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test34 : MonoBehaviour
{
    public string C;

    void Start()
    {
        Test();
    }

    void Test()
    {
        char c = 'C';

        Debug.Log((int)c - (int)'A');

    }
}
