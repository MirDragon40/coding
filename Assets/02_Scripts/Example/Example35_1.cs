using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example35_1 : MonoBehaviour
{

    /**
     //��ȯ �ڷ����� ���� ���: void
    '��ȯ �ڷ���' '�Լ� �̸�'('�Ű����� ���')
       {
           // ������ �ڵ带 
           // return ��ȯ ������
       }
    **/


    // 1. �Ű�������: �Լ��� ȣ��(����)�� �� ���޵Ǵ� ��. �Ű������� ���������̴�.
    // 2. return�̶�:
    //      - return �� ȣ��Ǹ� �Լ��� ����
    //      - ���α׷��� �帧�� ȣ���ڿ� �����ش�.
    //      - �̶� Ư�� '��ȯ �ڷ���'�� �����͸� ��ȯ�Ѵ�.


    // Sum�̶�� �Լ��� �Ű� ���� �ΰ��� �޾Ƽ� ���� ó�� �� int  �ڷ����� �����͸� �����ִ� �Լ��̴�.
    int Sum(int num1, int num2)  // �Լ� �̸�: 'Sum'  ��ȯ������: 'result' ��ȯ �ڷ���: 'int'
    {
        int result = num1 + num2;
        return result;
        // return: �Լ��� ������(����), �Լ��� �����ش�(��ȯ). return �Ʒ��� ���� �ڵ�� ������ ���� �ʴ´�.

        // ������ return�� ȣ���� �Լ��� ���������Ƿ� �Ʒ� �ڵ�� ������� �ʴ´�. 
        Debug.Log(1111111);
    }

    int Sub(int num1, int num2)
    {
        int result =  num1 - num2;
        return result;
    }


    int Mul(int num1, int num2)
    {
        int result = num1 * num2;
        return result;
    }

    int Div(int num1 , int num2)
    {
        int result = num1 / num2;
        return result;
    }

    void Start()
    {

        // ���ϱ� 
        int result = Sum(436, 575);
        Debug.Log(result);

        // ����
        result = Sub(17, 9);
        Debug.Log(result);

        // ���ϱ� 
        result = Mul(22, 78);
        Debug.Log(result);

        // ������
        result = Div(102305, 55);
        Debug.Log(result);
    }

}
