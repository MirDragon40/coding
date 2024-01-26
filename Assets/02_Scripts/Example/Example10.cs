using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example10 : MonoBehaviour
{
    public string MyName;
    void Start()
    {
        // 2. ����/���ڿ� ��
        // ����: char
        // ���ڿ�: string

        char charValue1 = '��';    // ���ڴ� ���� ����ǥ ���. �� ���ڸ� ���
        char charValue2 = '1';
        char charValue3 = '+';
        string stringValue = "������";     // ���ڿ��� ū ����ǥ ���. ���� ���ڸ� ���

        // ���ڿ��� �ٷ�� �溱
        // 2-1. ���ڿ� ���� string, format
        string str1 = "�ȳ� ������";
        string str2 = string.Format("{0} {1}", "�ȳ�", "������");
        string str3 = string.Format("{0} {1}", "�ȳ�", MyName);
        // ù ��° ������ ���ڿ� ������ ������ ����
        // �� ��° �������� ���ڿ� ������ ����

        int hour = 1;
        int minute = 15;

        Debug.Log(string.Format("{0}{1}", hour, minute)); // 115
        Debug.Log(string.Format("{0}:{1}", hour, minute)); // 1:15
        Debug.Log(string.Format("����ð�: {0}:{1}", hour, minute)); // ����ð�: 1:15

        // ����
        Debug.Log(string.Format("{0, -5}:{1}", hour, minute)); // 1:15
        Debug.Log(string.Format("{0, -5}:{1}", hour, minute));  // 1:15

        // ���� ����
        Debug.Log(string.Format("{0:D5}:{1}", hour, minute));  // 00001:15


        float fValue = 3.123456f;
        // �Ҽ��� ����
        Debug.Log(string.Format("�Ҽ��� 1�ڸ��� ǥ��:{0:F1}", fValue));  // 1:15

        // 2-2. ���ڿ� ����
        // $"�ؽ�Ʈ(����, ����)�ؽ�Ʈ"
        Debug.Log($"�Ҽ��� 1�ڸ��� ǥ��:{fValue:F1}");  // ������ ���� �� �ִ� ���

        // 2-3. Ž��

        // 2-4. ����

        // 2-5. ����
    }


}
