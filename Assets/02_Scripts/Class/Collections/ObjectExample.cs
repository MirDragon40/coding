using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectExample : MonoBehaviour
{

    void Start()
    {
        // C#�� ��� �ڷ����� System.object�� ��ӹ޴´�.
        // � �����͵� �ٷ� �� �ִ� Ÿ��
        // ������ (���� �����Ͱ� ����Ǿ� �ִ� ��ġ(�ּҰ�)�� �����Ѵ�.)

        // �ڽ�(Boxing)
        // ���� �޸𸮿� �Ҵ�� �� ������ �����͸� ���� �Ҵ��ϴ� ��
        // (object ���Ŀ� �� ������ �����͸� �Ҵ��ϸ� �ڽ��� �Ͼ��.)
        object intValue = 31;
        object floatValue = 150.1f;
        object boolValue = false;

        // ��ڽ� (Unboxing)
        // �տ� ����� �� ������ �����͸� �� ���� ������ �Ҵ��ϴ� ��
        // (object ������ �����͸� �� ������ ��ü�� �Ҵ��ϸ� ��ڽ��� �Ͼ��.)
        int valueInt = (int)intValue;
        float valueFloat = (float)floatValue;
        bool valueBool = (bool)boolValue;

        intValue = (object)valueInt;
        floatValue = (object)valueFloat;
        boolValue = (object)valueBool;

        Debug.Log(intValue);
        Debug.Log(floatValue);
        Debug.Log(boolValue);

    }

}
