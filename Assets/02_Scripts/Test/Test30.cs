using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test30 : MonoBehaviour
{
    public int[] nums;
    


    void Start()
    {
        int[] empty = new int[42];
        int count = nums.Length;

        for (int i = 0; i < count; i++)
        {
            int num = nums[i]%42;
            empty[num] = 1 ;
            
        }

        int sum = 0;

        for (int i = 0; i < 42; i++)
        {

            if (empty[i] == 1)
            {
                sum++;
            }

        }

        Debug.Log(sum);
    }
}



