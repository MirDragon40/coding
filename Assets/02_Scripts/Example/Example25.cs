using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example25 : MonoBehaviour
{
    public int[] N;

    private void Start()
    {
        // Length �Ӽ�: �迭�� ����
        Debug.Log(N.Length);

        int count = N.Length;

        for (int i = 0; i < count; i++)
        {
            Debug.Log(N[i]); // �迭�� ���� �׷��� �����͸� ���̰����ϴ� ����� (���α׷����� ����)
        }

    }
}
