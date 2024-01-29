using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class People : MonoBehaviour
{

    // ����ȭ: ��ü�� �Ӽ��� �ܺο��� ���� �������� ���ϵ��� �����ϴ� ����
    // ĸ��ȭ:
    // ������(�Ӽ�)�� �����͸� ó���ϴ� ����(�޼���)�� �ϳ��� ���� ��
    // ���� �Ӽ��� ����ȭ�ϰ� ������ ���� �Ӽ��� ����/���� �ϰ� �����λ�
    // �߸��� �����̳� �ǵ�ġ �ʴ� ������ ���ϴ� ��ȣ ȿ���� ������. 
    private int Age;
    private string Name;


    // ������Ƽ:
    // �Ӽ��̶�� ������ ������ ���� �ܺο��� ������ �� �ֵ��� �ϸ鼭
    // ���ÿ� ĸ��ȭ�� �����ϴ� C# �� ����̴�.
    // - get ������: ��� �����κ��� ���� �о��ش�.
    // - set ������: ��� ������ ���� �Ҵ��Ѵ�.
    private float _height;
    public float Height
    {
        get // ������Ƽ ���ο� get�� �����ϸ� �б� ����
        {
            return _height;
        }
        set // ������Ƽ ���ο� set�� �����ϸ� ���� ����
        {
            if (value < 0)
            {
                return;
            }

            _height = value;  // value Ű����� set �������� �Ű� ����
        }
    }



    private string _MBTI;
    public string MBTI
    {
        get
        {
            return _MBTI;
        }
        set
        {
            if (value.Length != 4)
            {
                return;
            }

            _MBTI = value;
        }
    }




    public People(string name, int age, float height, string mbti)
    {
        Name = name;
        Age = age;
        _height = height;
        MBTI = mbti;
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

    // ��� ���� ����ȭ/ĸ��ȭ ������
    // �Ӽ��� ���� �����Ҽ��� Get/Set �� ���� �޼ҵ尡 ��������, (�ڵ差�� �������Ƿ� ������...)
    // ������ �����Ѵٴ� ������ �ƴ� �޼ҵ带 ����Ѵٴ� ������ Ŀ����. 

    // �� �������� �����ϱ� ����...

}
