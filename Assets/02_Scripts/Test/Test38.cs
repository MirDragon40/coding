using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Test38 : MonoBehaviour
{
    public string S;
    //  Debug.Log(S.IndexOf('e'));

    void Start()
    {
        string alpa = "abcdefghijklmnopqrstuvwxyz";

            
        for (int i = 0; i < alpa.Length; i++)
        {
            Debug.Log(S.IndexOf(alpa[i]));
        }
    }
}
