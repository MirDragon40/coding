using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example38 : MonoBehaviour
{
    // 가변 길이 매개 변수
    // -> 매개변수 개수가 유연하게 변한다.

    int Add(params int[] nums)
    {
        int sum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }

        return sum;

    }


    void Start()
    {

        Add(1);
        Add(1, 2);
        Add(1, 5, 2);
        Add(1, 3, 3, 56, 463);
        Add(1, 3, 3, 56, 463, 674);
        Add(1, 3, 3, 56, 463, 45654);
        Add(1, 3, 3, 56, 98950, 3435, 4353);

        Debug.Log(Add(1, 2));
        Debug.Log(Add(1, 3, 3, 56, 98950, 3435, 4353));
        
    }

}
