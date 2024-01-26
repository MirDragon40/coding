using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test37 : MonoBehaviour
{
    public string S;

    void Start()
    {
        string s = "";

        for (int i =S.Length-1; i >= 0; i--)
        {
            s += S[i];   

        }
        Debug.Log(s);
    }

}
