using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example07 : MonoBehaviour
{
    // ������
    // ���(����) ���� ������: ��� ������ ������ �����ϱ� ���� ����ϴ� Ű����
    // private: Ŭ���� ���ο����� ���� �����ϴ�. (default)
    // public: �ܺο��� �����Ӱ� ���� �����ϴ�.
    public string name = "Ƽ��";
    public int age = 10;
    public float height = 148.3f;


    void Start()
    {
        Debug.Log("�ȳ��ϼ���. C# �Դϴ�.");
        Debug.Log("�̸�: " + name);
        Debug.Log("����: " + age);
        Debug.Log("Ű: " + height);
    }
}

