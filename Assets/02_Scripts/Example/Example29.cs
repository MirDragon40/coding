using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Example29 : MonoBehaviour
{

    private void Start()
    {
        int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7 };

        // arr �迭�� �ִ� ��� ���� for �ݺ����� �̿��ؼ� ����ϰ� �ʹ�.
        for (int j = 0; j < arr.Length; j++)
        {
            Debug.Log(arr[j]);
        }

        // foreach �ݺ���
        /**
            foreach (�ڷ��� ������ in �迭)
            {
                // ������ ����ϴ� �ڵ�
            }
         **/

        // foreach: �ε����� �ݺ� Ƚ�� �Ű� �� �ʿ� ���� �迭�� ��� ��ҿ� ������ �� �ִ�.
        // ����: �ڵ尡 �پ���. -> ������ ���
        // ����:  �� ����� ���� ������ �� ����.

        foreach (int num in arr)
        {
            Debug.Log(num);
        }

        int i = 0;
        foreach (int num in arr)
        {
            Debug.Log(i);
            Debug.Log(num);
            i++;
        }
    }

}
