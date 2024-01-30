using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericExample : MonoBehaviour
{
    void Start()
    {
        Person<int, float> p1 = new Person<int, float>();
        p1.Name = "����";
        p1.Age = 34;

        Person<int, int> p2 = new Person<int, int >();
        p1.Name = "�ƺ�";
        p1.Age = 33;

        // ���ڱ� ��� �������� �䱸���� Age�� int�� �ƴ� float ���� ��ƾ� �ϴ� �䱸����

        Person<float, float> p3 = new Person<float, float>();
        p3.Name = "�Ƶ�";
        p3.Age = 0.8f;

    }

    // ���׸�(Generic: �Ϲ�ȭ)�� Ÿ��(�ڷ���)�� �̸� �������� �ʰ�, ����� �� �������� �����ϴ°�
    // ���׸��̶� "Ÿ�Կ� �������~"
    // ���� ���� Ÿ���� �����ϰ� ����� �� �ִ�.
    public class Person<T1, T2>      // 2. �׸��� Ŭ���� �̸� ���� <T> �߰��������ν�
                                //    ��ü�� ������ �� �� Ÿ��(T)�� �����ϰ� �Ѵ�.
    {
        public string Name;
        public T1 Age;           // 1. ���� Age �Ӽ��� Ÿ���� �̸� ������ �ʰ� T��� �Ѵ�.
        public T2 Weight;

        public void SetAge(T1 value)
        {
            Age = value;
        }

        public T1 GetAge()
        {
            return Age;
        }
        // Update is called once per frame
        void Update()
        {

        }

    }

}
