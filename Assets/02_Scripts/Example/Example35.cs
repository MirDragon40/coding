using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example35 : MonoBehaviour
{

    /**
     //��ȯ �ڷ����� ���� ���: void
    '��ȯ �ڷ���' '�Լ� �̸�'('�Ű����� ���')    // �Ű����� ����� �޸��� ����
       {
           // ������ �ڵ带 
           // return ��ȯ ������
       }
    **/

    int Sum(int num1, int num2)
    {
        int result = num1 + num2;
        return result;

    }

    void Start()
    {
        // ���ϱ� 
        int num1 = 0;
        int num2 = 0;
        int result = 0;

        num1 = 1;
        num2 = 3;
        result = num1 + num2;
        Debug.Log($"{num1} + {num2} = {result}");

        num1 = 17;
        num2 = 9;
        result = num1 + num2;
        Debug.Log($"{num1} + {num2} = {result}");

        num1 = 22;
        num2 = 33;
        result = num1 + num2;
        Debug.Log($"{num1} + {num2} = {result}");
    }

}
