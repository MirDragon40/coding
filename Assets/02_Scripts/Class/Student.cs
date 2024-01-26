using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Ŭ����: ��ü�� �ϳ��� �������� ���� ����, Ʋ
// ��ü�� '����� ����'�� '����ϴ� ����'�� �ʿ��ѵ�
// ��ü�� � �Ӽ��� �ְ� � ���(����)�� �ϴ��� �����ϴ� ���赵


public class Student : MonoBehaviour
{
    // �Ӽ�(��� ����)
    // ��� ����: Ŭ������ �Ҽӵ� ����
    // ���� Ŭ������ �ҼӵǾ� �ִ� �Լ��� �� ������ ���� ���� ��� ����
    public string Name;
    public int Age;
    private float _weight;     // ���������� �ҹ���, �ۺ� ������ �빮�ڷ� ����


    // ������: new Ű���带 �̿��ؼ� ��ü�� ������ ��, �ڵ����� ȣ��Ǵ� �Լ�
    // �� ������ �� ȣ���ϴ� �Լ�
    // �� ��ȯ �ڷ����� �Ƚ��ְ�, Ŭ���� �̸��� �����ϰ� �����.
    // �� �ַ� ��ü ������ ���ÿ� �Ӽ�(��� ����)�� �ʱ�ȭ�� �� ����Ѵ�.

    // �⺻ ������: �Ű� ������ ���� �����ڴ� �ٸ� �����ڰ� ���� ��� �ڵ����� �����ȴ�.

    public Student()     
    {
        _weight = 50f;
    }  // �����ε�

    public Student(string name, int age, float weight)  // ������ �� �������鼭 �� �� �ʱ�ȭ�� ���ְڴٴ� �ǹ�
    {
        Name = name;
        Age = age;
        _weight = weight;
    }

    // �ൿ(��� �Լ�)
    // ���� Ŭ������ �ҼӵǾ� �ִ� �Լ������� ���� ���� ȣ�� ����
    public void Speak()
    {
        Debug.Log($"�ȳ�. �� �̸��� {Name}�̰�, ���̴� {Age}���̾�");
    }

    public void HighFive(Student otherStudent)  
    {
        Debug.Log($"{Name}�� {otherStudent.Name}�� �������̺긦 �ߴ�!");
    }
}
