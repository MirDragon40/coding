using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example31 : MonoBehaviour
{


    void Start()
    {
        // 배열 초기화 (선언과 동시에 초기값을 넣어주는 것)

        // 1차원 배열 초기화
        int[] arr = new int[] { 1, 2, 3 };
        Debug.Log(arr);

        // 2차원 배열 초기화 
        int[,] arr2 = new int[,]
        {
            { 31, 28, 45},
            { 10, 56, 68}
        };
    }


}
