using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_0109 : MonoBehaviour
{
    // Q1. ���� 2���� �Ű������� �Ѱܹ޾� �� ���� �� ū ���� ��ȯ�ϴ� �Լ��� ����� �׽�Ʈ
    int MaxNums(int num1, int num2)    // ����κ�
    {
        //int Max = 0;
        //if (num1 > num2)
        //{
        //    Max = num1;
        //}
        //if (num1 < num2)
        //{
        //    Max = num2;
        //}
        //return Max;


        if(num1 > num2)              // �����κ�
        {
            return num1;
        }

        return num2;
    }


    // Q2. ���� 3���� �Ű������� �Ѱܹ޾� ����� ���� ��ȯ�ϴ� �Լ��� ����� �׽�Ʈ (����� �Ҽ����� ����)
    float AverNums(int num1, int num2, int num3)   // �Լ� �̸��� �׻� �빮�ڷ�
    {
        return (float)(num1 + num2 + num3)/3;   // ������ �ϴ� ���� float - �Ǽ����̹Ƿ� �Լ��̸� �� ������
                                                // float�̶�� �����ش�.
    }

    // Q3. ���� 1���� �Ű������� �Ѱܹ޾� 0���� �ش� ���������� ������ִ� �Լ��� ����� �׽�Ʈ (��ȯ����)
    void LogNums(int num1)
    {
        for (int i= 0; i <= num1; i++)
        {
            Debug.Log(i);
        }
    }

    void Start()
    {

        // ȣ��: �Լ��̸�(�Ű�����);
        Debug.Log(4);


        int result = MaxNums(34, 23);

        Debug.Log(MaxNums(15, 45));

        Debug.Log(AverNums(133, 425, 23));

        LogNums(35);

        Debug.Log(Mathf.Max(6,4));

    }
}
