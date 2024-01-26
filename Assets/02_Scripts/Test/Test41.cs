using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test41 : MonoBehaviour
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

        /*
        int max = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length > max)
            {
                max = inputArray[i].Length;
            }
        }

        string all = "";
        for (int i = 0; i < max; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                all += inputArray[i][j];
            }
        }

        Debug.Log(all);
        */

        int max = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length > max)
            {
                max = inputArray[i].Length;
            }
        }

        char[,] all = new char[inputArray.Length, max];

        for (int x = 0; x < inputArray.Length; x++)
        {
            for (int y = 0; y < max; y++)
            {
                if (inputArray[x].Length > y)
                {
                    all[x, y] = inputArray[x][y];
                }
                else
                {
                    all[x, y] = ' ';
                }


            }
        }

        string add = "";
        for (int x = 0; x < max; x++)
        {
            for (int y = 0; y < inputArray.Length; y++)
            {
                if (all[y, x] == ' ')
                {
                    add = add;
                }
                else
                {
                    add = add + all[y, x];
                }
            }
        }

        // Debug.Log(add.Replace(" ", ""));
        Debug.Log(add);
    }

}
