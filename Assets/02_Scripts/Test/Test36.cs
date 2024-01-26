using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test36 : MonoBehaviour
{
    public string S;


    void Start()
    {

        int sum = 0;

        //int changeS = int.Parse(S);
        for (int i = 0; i < S.Length; i++)
        {
            sum = sum + int.Parse($"{S[i]}");
            
        }
        Debug.Log(sum);

    }

}
