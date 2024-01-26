using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example15 : MonoBehaviour
{
    void Start()
    {
        // �������� �� ��ȯ
        // -> ������ ����ִ� �����͸� �ٸ� ������ Ÿ��(�ڷ���)�� ������ �Ű� ��� ��

        // 1. ���� ������ ��ȯ

        sbyte sbyteValue = 10;                      // short ����:  -128 ~ 127
        int intValue = (int)sbyteValue;             // int ����:    -21�� ~ 21��

        Debug.Log($"sbyteValue: {sbyteValue}");   //10
        Debug.Log($"intValue: {intValue}");       //10


        // 1-1. �Ű� ��� �ڷ����� ���۰�, ���� ������ �Ѿ����
        intValue = 130;
        sbyteValue = (sbyte)intValue;
        Debug.Log($"sbyteValue: {sbyteValue}");     // -126 (�����÷ο� �߻�)
        Debug.Log($"intValue: {intValue}");

        // 2. �Ǽ� ������ ��ȯ (float, double, decimal)
        // �Ǽ��� �����÷ο찡 �������� �ʰ�, ���е��� �ջ��� �Դ´�.
        double doubleValue = 3.1415982378948639892543;
        float floatValue = (float)doubleValue;
        Debug.Log($"doubleValue: {doubleValue}");
        Debug.Log($"floatValue: {floatValue}");

        // 3. �Ǽ��� ������ ����ȯ
        // ����: �Ҽ��� �Ʒ��� ������ �Ҽ��� ���� ���� �����. (�ݿø� ���� �ƴ�)
        // 0.1f -> 0
        // 0.9f -> 0
        // 1.1f -> 1
        // 3.14151231232 -> 3
        float floatValue2 = 0.9f;
        int intValue2 = (int)floatValue2;
        Debug.Log($"intValue2: {intValue2}"); // 0

        // 4. ���ڸ� ���ڷ� ����ȯ
        // ToString() �޼ҵ带 �̿� (�޼ҵ�� �Լ� �Ǵ� ����̶�� �ǹ̸� ������ ����)
        int intValue3 = 10;
        string stringValue3 = intValue3.ToString();
        Debug.Log($"stringValue3: {stringValue3}");


        // 5. ���ڿ��� ���ڷ� ����ȯ
        // 5-1. Parse() �޼ҵ带 �̿�
        // ����ڷκ��� ���� ���ڸ� ���ڷ� ��ȯ�ϴ� ���� Ư�� ������ ���� ����.
        string stringValue5 = "4354";
        int intValue5 = int.Parse(stringValue5);
        Debug.Log($"intValue5: {intValue5}");


        // 5-2. TryParse() �޼ҵ� �̿��ϱ�
        // -> �� ��ȯ ���� ���θ� �������� �˷��ش�.
        string stringValue6 = "4352������������ȣȣ";
        int intValue6;
        bool isSuccess = int.TryParse(stringValue6, out intValue6);
        if (isSuccess)
        {
            Debug.Log($"��ȯ ���: {isSuccess}");
        }
        else
        {
            Debug.Log("��ȯ ����");
        }
    }

    
}
