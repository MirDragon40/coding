using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example31 : MonoBehaviour
{


    void Start()
    {
        // �迭 �ʱ�ȭ (����� ���ÿ� �ʱⰪ�� �־��ִ� ��)

        // 1���� �迭 �ʱ�ȭ
        int[] arr = new int[] { 1, 2, 3 };
        Debug.Log(arr);

        // 2���� �迭 �ʱ�ȭ 
        int[,] arr2 = new int[,]
        {
            { 31, 28, 45},
            { 10, 56, 68}
        };
    }


}
