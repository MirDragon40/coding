using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class StaticTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //MyStudent.Number = 13; // Ŭ���� ��ü�� �Ҽ� (Ŭ����.������)

        //MyStudent example = new MyStudent();
        //// example.Number = 13;
        //example.Age = 10;



        MyStudent student1 = new MyStudent("���μ�", 11);
        MyStudent student2 = new MyStudent("�̼���", 22);
        MyStudent student3 = new MyStudent("�迹��", 33);

        // student1.Hello();  // -> �̷��� �����ϴ� ���� �ƴ϶� 
        MyStudent.Hello();    // -> �̷��� �������־�� �Ѵ�.

        Debug.Log($"���� �л� ��: {MyStudent.GetNumber()}��");   // MyStudent ���� �Լ��� ȣ���Ͽ�,���� �޾ƿ��� �ȴ�. 
        // �л����� MyStudent.Number�� ���� ����


        // static�� ��ƿ��Ƽ ���� �Լ��� ����ų� ����� �� �����ϴ�.
        // ��ƿ��Ƽ �Լ���: ���� ���� �� �ݺ������� ���Ǵ� �����ϰ� �ǿ����� �Լ�
        // stfing(���ڿ�), Mathf(����), Vector2(����), �����(Debug)
        string.Format("{0}", 1);
        Mathf.Max(1, 2, 3, 43);
        Vector2 dir = Vector2.up;
        Debug.Log(123);

        // ���� 
        // 1. ���ټ�:
        // ��𿡼��� ������ ��ü �������� Ŭ���� �̸������� ������ �� �־ ���� ����� �� �ִ�.

        // 2. ���ҽ�(�޸�) ����:
        // Ŭ������ ��ü�� ������ �ʿ䰡 �����Ƿ� �޸� ��뷮�� ���� �� �ִ�.
        // ��, �ݺ������� ���Ǵ� ��ƿ��Ƽ �Լ��� �־ ȿ�����̴�.

        // 3. ����(�Ӽ�) ������: -> ���� �߿�
        // �Ϲ������� ��ƿ��Ƽ �Լ��� �Ӽ�(����)�� ������ �ʿ䰡 ����. ��ü�� ����� �������� �����Ƿ�
        // �Է¿� ���ؼ��� �����Ѵ�.


    }

}
