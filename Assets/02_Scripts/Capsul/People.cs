using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class People : MonoBehaviour
{
    private string Name;

    // ����ȭ: ��ü�� �Ӽ��� �ܺο��� ���� �������� ���ϵ��� �����ϴ� ����
    private int Age;

    // ĸ��ȭ:
    // ������(�Ӽ�)�� �����͸� ó���ϴ� ����(�޼���)�� �ϳ��� ���� ��
    // ���� �Ӽ��� ����ȭ�ϰ� ������ ���� �Ӽ��� ����/���� �ϰ� �����λ�
    // �߸��� �����̳� �ǵ�ġ �ʴ� ������ ���ϴ� ��ȣ ȿ���� ������. 

    public People(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Get/Set -> ������(�Ӽ�)�� �ܺο��� �а�/���� �� ���Ἲ�� ���� �� �����Ƿ� 
    // �����ʹ� �޼��带 ���� �а�/�����ϴ� �� ����. 
    public int GetAge()  // Get000 ->  �Ϲ������� �ܺο��� ��ü�� �����͸� ���� �� ���� �޼���
    {
        // ���⿡�� ���� �� �ܺη� ������ ���� �ִ�. (������ ���� VS �ѱ� ����)
        return Age;
    }

    public void SetAge(int age)  // Set000 -> �Ϲ������� �ܺο��� ��ü�� �����͸� ������ �� ���� �޼���
    {
        // �¿����� ������ ���� ��ȿ�� ���� �����ϵ��� �� �� �ִ�. 
        if (age < 0)
        {
            Debug.Log("0�캸�� ���� ���̸� �Ҵ��Ϸ��� �Ѵ�. ");
            return;
        }

        if (age < this.Age)
        {
            Debug.Log("���� �Է��ϴ� ���̴� ���� ���̺��� Ŀ�� �Ѵ�.");
            return;
        }

        Age = age;

    }

    public string GetName()
    {
        return Name;
    }
}
