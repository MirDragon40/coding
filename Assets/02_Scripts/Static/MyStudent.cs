using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyStudent
{
    // static(����) -> Ŭ������ ��ü�� �ƴ� Ŭ���� ��ü�� �Ҽ�
    // Ŭ������ �����ϰ� ��ü�� �����Ͽ� ��ü�� ���(����, �޼ҵ�)�� �����ϴ�
    // ���� ��İ� �ٸ��� ��ü�� �������� �ʰ� Ŭ���� ��ü���� ����� ����� �� �ִ�.
    // �� �ٸ� �̸��� '����'��.

    // public static int Number = default(int);  // ���� ����
    private static int Number;

    public string Name;
    public int Age;

    public MyStudent(string name, int age)
    {

        this.Name = name;
        Age = age;

        Number++;
    }

    // �޼ҵ� ��ȯ �ڷ��� �տ� 'Static' Ű���� ���
    // ���� �޼ҵ�� ��ü�� ������� Ŭ���� �̸����� �ٷ� ȣ���� �� �ִ�.
    public static void Hello()
    {
        // ���� �޼ҵ� ���ο����� ����� ������ �� ����. (������ �� ����.)
        // (Ŭ������ ���������Ƿ� Ŭ������ ��ü/����ʹ� ������ ����.)
        // Debug.Log($"�ȳ�, �� �̸��� {Name}�̾�.");
        Debug.Log("Hello");
    }

    public static int GetNumber()
    {
        return Number;
    }
}
