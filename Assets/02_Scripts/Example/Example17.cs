using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Example17 : MonoBehaviour
{

    public string Id;
    public string Passward;
    

    const string ID = "Teemo";
    const string PASSWARD = "1234";


    void Start()
    {
        // 1. ID�� �ٸ��� "�������� �ʴ� ID �Դϴ�."
        // 2. ID�� ������ ��й�ȣ�� �ٸ��� "��й�ȣ�� Ʋ�Ƚ��ϴ�."
        // 3. ID�� ��й�ȣ�� ��� ������ ���: "�α��� �ƽ��ϴ�."


        bool result1 = Id == ID;
        if (result1 == false)
        {
            Debug.Log("�������� �ʴ� ID �Դϴ�.");
        }

        bool result2 = Passward == PASSWARD;
        if (result1 == true && result2 == false)
        {
            Debug.Log("��й�ȣ�� Ʋ�Ƚ��ϴ�.");
        }

        if (result1 == true && result2 == true)
        {
            Debug.Log("�α��� �ƽ��ϴ�.");
        }

        // ����� Ǯ��
        if (Id != ID)
        {
            Debug.Log("�������� �ʴ� ID�Դϴ�.");
        }
        if (Id == ID && Passward != PASSWARD)
        {
            Debug.Log("��й�ȣ�� Ʋ�Ƚ��ϴ�.");
        }

        if (Id == ID && Passward == PASSWARD)
        {
            Debug.Log("�α��� �ƽ��ϴ�.");
        }

        // ��ø���ǹ�: ���ǹ� �ȿ� �� �ٸ� ���ǹ��� �� �ִ� ����
        // �������ǹ�, �������ǹ��� ������. but �������ǹ� ������ ���
        // 3�� ���ǹ��� �Ǹ� '���� ���� �߸��ϰ� ���� ������?' �����غ���

        if (Id != ID)
        {
            Debug.Log("�������� �ʴ� ID�Դϴ�.");
        }
        else
        {
            if (Id == ID && Passward != PASSWARD)
            {
                Debug.Log("��й�ȣ�� Ʋ�Ƚ��ϴ�.");
            }

            else  // (Id == ID && Passward == PASSWARD)
            {
                Debug.Log("�α��� �ƽ��ϴ�.");
            }
        }
    }

}
