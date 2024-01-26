using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test42 : MonoBehaviour
{
    public int[] Pieces;

    void Start()
    {

        int[] allPieces = new int[] {1,1,2,2,2,8};

        int[] subPieces = new int[6];

        string result = "";

        for (int i = 0; i < Pieces.Length; i++)
        {
            subPieces[i] = allPieces[i] - Pieces[i];
            result += subPieces[i] + " ";
        }

        Debug.Log(result);
        

    }

}
