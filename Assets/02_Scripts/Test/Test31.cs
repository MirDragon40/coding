using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test31 : MonoBehaviour
{
    public string S;
    public int i;

    void Start()
    {
        string a = $"{S[i - 1]}";
        Debug.Log(a.ToUpper());
    }

}
