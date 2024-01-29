using System.Collections;           // �÷���
using System.Collections.Generic;
using UnityEngine;

public class ArrayListExample : MonoBehaviour
{
    void Start()
    {
        // ���� �迭�� ����
        // 1. �迭�� ������ �� ������ �迭�� ũ�⸦ ������ �� ����.
        string[] students = new string[4] { "�ο���", "���μ�", "�̼���", "��¿�" };
        students[0] = "";
        // 2. �����͸� �迭�� �߰��ϰų� �����ϴ� ��� ��ȿ������ ������ �ʿ��ϴ�. 
        // (�߰��� �����͸� �����ϰų� ������ ��� ��� �������� �ε��� ������ ����)

        // -> �̷� ������ �ذ��ϱ� ���� '�÷���' ���
        // �����͸� �ٷ�� �ڷᱸ���� �����͸� ó���ϴ� �˰����� ����ȭ�Ͽ� ���ϰ� Ŭ������ ������ ���� ��
        // ArrayList, HashTable

        // �÷����� ����:
        // "�ڽ�/��ڽ�"���� ���� �������� ������ �߻��Ѵ�.






        // ArrayList: �ʿ信 ���� ũ�Ⱑ �������� ���ϴ� �迭
        // - �迭�� �޸� ũ�⸦ ������ �ʿ䰡 ����. 
        // - Ư�� �ڷ��� �Ӹ� �ƴ϶� ���� �ڷ����� �����͸� ���� �� �ִ�. 

        // ���� ����
        ArrayList myList = new ArrayList();

        // ������ �߰�
        Debug.Log($"�������� ����: {myList.Count}");
        myList.Add("�ο���");
        myList.Add("���μ�");
        myList.Add("�̼���");
        Debug.Log($"�������� ����: {myList.Count}");
        myList.Add("��¿�");
        myList.Add(123);
        myList.Add(false);
        Debug.Log($"�������� ����: {myList.Count}");
        myList.Add(123.1f);      // �ڽ�

        // �ε����� �̿��� ������ ��ȸ
        Debug.Log(myList[0]);    // ��ڽ�
        Debug.Log(myList[1]);
        Debug.Log(myList[2]);
        Debug.Log(myList[3]);
        Debug.Log(myList[4]);
        Debug.Log(myList[5]);
        Debug.Log(myList[6]);

        // ����Ʈ ���� �Ӽ�
        Debug.Log($"�������� ����: {myList.Count}");
        for (int i = 0; i < myList.Count; i++)
        {
            Debug.Log(myList[i]);
        }
        Debug.Log($"--------------------------------------------------");

        // ����/����
        // - Remove():   ������ ����� ���� �Ű������� ����
        // - RemoveAt(): ������ ����� �ε����� �Ű������� ����
        myList.Remove("���μ�");
        for (int i = 0; i < myList.Count; i++)
        {
            Debug.Log(myList[i]);
        }

        Debug.Log($"--------------------------------------------------");


        // ���� 
        // - Add()�� �������� �� ���� �߰�
        // - Insert()�� ������ �ε����� �����͸� ����
        myList.Insert(0, "�ο���");
        myList.Insert(3, "������");
        for (int i = 0; i < myList.Count; i++)
        {
            Debug.Log(myList[i]);
        }

        Debug.Log($"--------------------------------------------------");


        // ������
        myList.Reverse();
        Debug.Log($"�������� ����: {myList.Count}");
        for (int i = 0; i < myList.Count; i++)
        {
            Debug.Log(myList[i]);
        }





    }
}
