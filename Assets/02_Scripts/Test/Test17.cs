using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test17 : MonoBehaviour
{
    public int N;

    void Start()
    {

        for (int i= 1; i <= 9; i++)
        {
            Debug.Log($"{N}*{i} = {N*i}");
        }
    }

}
