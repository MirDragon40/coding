using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example24 : MonoBehaviour
{
    void Start()
    {
        // �迭�� �ʱ�ȭ: �迭�� ����� ���ÿ� ���� �Ҵ��ϴ� �� -> �Ҵ��� �� -> �ʱⰪ
        // 3���� ���

        // 1. ù ��° ���
        int[] scores = new int[5] { 100, 99, 98, 97, 95 };  // ������ �����ϴ� ���

        // 2. �� ��° ���: ù ��° ������� �迭�� ũ�� ����
        int[] score2 = new int[] { 100, 99, 98, 97, 95, 1 };

        // 3. �� ��° ���: �� ��° ������� new �����ڿ� �迭�� ũ�� ��� ����
        int[] score3 = { 100, 99, 98, 50 };


    }

}
