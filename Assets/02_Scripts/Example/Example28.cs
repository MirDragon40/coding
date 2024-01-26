using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example28 : MonoBehaviour
{


    void Start()
    {
        // 1. ���ڿ� Ž��
        // 1-1. Contains
        string str = "Hello, World";

        // Q. ���ڿ� �ȿ� "Wor" ���ڿ��� �ִ°�?
        string test = "Wor";
        Debug.Log(str.Contains(test));

        // Q. ���ڿ� �ȿ� 'e'��� ���ڰ� �� ��° �ִ°�?
        Debug.Log(str.IndexOf('e'));

        // Q. ���ڿ��� 'He'�� �����ϴ°�?
        Debug.Log(str.StartsWith("He"));

        // 2. ���ڿ� ����
        string str2 = "  Hello  ";

        // ���ڿ��� ��� �빮�ڷ� ����ϱ�
        Debug.Log(str2.ToUpper());
        str2 = str2.ToUpper();
        // ���ڿ��� ��� �ҹ��ڷ� ����ϱ�
        Debug.Log(str2.ToLower());
        // ���ڿ��� ��, �� �ʿ� �ִ� ������ ����
        Debug.Log(str2.Trim());

        Debug.Log(str2);

        // 3. ���ڿ� ����
        // 3-1. Split: �־��� ���� Ȥ�� ���ڿ��� �������� ����
        string str3 = "����� ������ ���μ� �̼��� �迹��";
        string[] names = str3.Split(" ");
        // names: [0]: "�����", [1]: "������", ... , [4]: "�迹��"
        for (int i = 0; i < names.Length; i++)
        {
            Debug.Log(names[i]);
        }

    }

}
