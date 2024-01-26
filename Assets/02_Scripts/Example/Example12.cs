using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example12 : MonoBehaviour
{
    // ����(���)�̶� ����� ���� ���ο� ���� ����� ��
    // "������"�� ������ ������ �� ���� ��ȣ
    void Start()
    {
        // 1. ��Ģ������
        // +, -, /(��), *(���ϱ�), %(������)
        int a = 5;
        int b = 3;

        Debug.Log($"{a} + {b}={a + b}");
        Debug.Log($"{a} / {b}={a / b}");
        Debug.Log($"{a} - {b}={a - b}");
        Debug.Log($"{a} * {b}={a * b}");
        Debug.Log($"{a} % {b}={a % b}");

        // 2. ���� ������
        // (�����)���� ������ ����(�Ҵ�)�ϴ� ������
        // �⺻ ���� ������
        int c = 3;

        // 00 ���� ������ 
        c = c + 5;   // �Ʒ��� �ڵ�� ���� �ǹ̸� ���´�.

        c += 5;
        Debug.Log($"c+=5: {c}");

        c -= 5;
        Debug.Log(c);

        c *= 3;
        c /= 7;

        // ����(����/����) ������
        // e.g) 1�� ���Ҷ�...
        c = c + 1; // ���� ������ 
        c += 1;    // ���� ���� ������
        c++;       // 1 ���� ������
        c--;       // 1 ���� ������ 

        ++c;

        int number = 10;
        Debug.Log(number);

        Debug.Log(number++); // 10 // ���� ����: �ٸ� ������ ���� ���� ��. 1�� ����
        Debug.Log(number);   // 11

        Debug.Log(++number); // 12 // ���� ����: �� 1 ���� �� �ٸ� ���� ����
        Debug.Log(number);   // 12


    }


}
