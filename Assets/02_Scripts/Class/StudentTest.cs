using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentTest : MonoBehaviour
{
    void Start()
    {
        Student student1 = new Student("���μ�", 30, 32.5f);
        student1.Name = "���μ�";
        student1.Age = 30;
        student1.Speak();

        Student student2 = new Student();
        student2.Name = "�̼���";
        student2.Age = 24;
        student2.Speak();


        student1.HighFive(student2);

        // null: ���������� �������� �ʴ´�, ����ִ�. 
        // ���� ����ϰ� ������ ����Ű�� ���� �� �ϳ�
        Student student3 = null;    // student3�� ����ִ�.
        // student3.Speak(); -> ����

        student3 = student2;
        student3.Name = "�迹��";
        Debug.Log(student2.Name); // "�̼���" vs "�迹��"
    }

}
