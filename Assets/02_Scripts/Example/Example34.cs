using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example34 : MonoBehaviour
{
    // �Լ��� ������ �������� Ư�� �۾��� �����ϴ� �ڵ� ���
    // ���� 1: ���� �����ϴ�.
    // ���� 2: �ݺ��Ǵ� �ڵ带 ���� �� �ִ�.
    // ���� 3: �ݺ��Ǵ� �ڵ带 ���� �� �ִ�.


    /**
      //��ȯ �ڷ����� ���� ���: void
     '��ȯ �ڷ���' '�Լ� �̸�'('�Ű����� ���')
        {
            // ������ �ڵ带 
            // return ��ȯ ������
        }
     **/

    void Start()
    {
        for (int i = 1; i <= 10; i++)
        {
            // �Լ��� ȣ��(���)
            // �Լ��̸�():
            Hello();
        }
        Hello();
    }

    void Hello()
    {
        Debug.Log("�ȳ��ϼ���.");
    }
}
