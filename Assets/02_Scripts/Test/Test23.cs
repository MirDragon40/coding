using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Playables;

public class Test23 : MonoBehaviour
{
    public int[] N;
    public int v;

    // 개수 세기
    void Start()
    {
        int sum = 0;
        int count = N.Length;

        for (int i = 0; i < count; i++)
        {
            if (N[i] == v)
            {
                sum++;
            }
        }
        Debug.Log(sum);
    }

}
