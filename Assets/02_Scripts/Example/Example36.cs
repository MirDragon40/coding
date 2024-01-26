using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example36 : MonoBehaviour
{

    // ��ȯ �����Ͱ� ���� ����: void
    void Hello()
    {
        return;  // ��ȯ �����Ͱ� ���� �Լ��� ��� return�� ȣ���ؼ�
                 // �Լ� �߰��� ���� �뵵�� ��� �����ϴ�.
        Debug.Log("Hello");
    }

    // �Լ� ���� �� 4���� ����� ��
    // 1. ��ȯ ������ �ְ�, �Ű� ���� �ִ� �Լ�           // int Sum(int,int)
    // 2. ��ȯ ������ ����(void), �Ű� ���� �ִ� �Լ�     // void Test(int)
    // 3. ��ȯ ������ �ְ�, �Ű� ���� ���� �Լ�           // int GetLength()
    // 4. ��ȯ ������ ����(void), �Ű� ���� ���� �Լ�     // void Hello()
    void Start()
    {
        Hello();

        // Q1.
        bool odd = IsOdd(32);
        Debug.Log(odd);

        // 3
        // Debug.Log(�ƹ��ų�) -> false

        
        // Q2.
        for (int i = 1; i <= 100; i++)
        {
            bool isOddNum = IsOdd(i);

            if (isOddNum == true)
            {
                Debug.Log(i);
            }
        }

        // ���� (Ȧ���ΰ�(i)? == true)
        for (int i = 1; i <= 100; i++)
        {
            if (IsOdd(i) == true)
            {
                Debug.Log(i);
            }
        }
    }

    // Q1. �Ű������� ������ �ϳ� �Է¹޾Ƽ� Ȧ���̸� true ¦���̸� .false�� ��ȯ�ϴ� �Լ�
    // �Լ���: IsOdd
    // Q2. Start �Լ� ������ 1���� 100���� for �ݺ����� ���鼭 IsOdd �Լ��� �̿��� Ȧ���� ���

    bool IsOdd (int num)
    {
        return num % 2 == 1;

        // bool odd = num % 2 == 1;
        // return odd;
        
    }
}
