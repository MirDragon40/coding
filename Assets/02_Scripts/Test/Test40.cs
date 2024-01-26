using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test40 : MonoBehaviour
{

    void Start()
    {
        char[][] inputArray = new char[][]
 {
    new char[] { 'A', 'A', 'B', 'C', 'D', 'D' },
  new char[] { 'a', 'f', 'z', 'z' },
  new char[] { '0', '9', '1', '2', '1' },
  new char[] { 'a', '8', 'E', 'W', 'g', '6' },
  new char[] { 'P', '5', 'h', '3', 'k', 'x' }
 };

        string read = "";

        for (int i = 0; i < inputArray.Length; i++)
        {
            for (int j = 0; j < inputArray[i].Length; j++)
            {
                read = read + inputArray[i][j];
            }
        }
        Debug.Log(read);
    }

}
