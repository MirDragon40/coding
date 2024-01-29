using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HashTableExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // HashTable
         // Ű(Key)�� ��(Value) ������ �̷���� �����͸� �ٷ� �� ���� �ڷᱸ��

         // (�����Ϳ� �����ϱ� ���� ���� �ε����� ����ϴ� ���� �ƴ϶�
         //  Ÿ���� �����ο� 'Ű'�� ����ϴ� ���̴�. ) (int, float, string, class �� � �����̵� ��� ����)

        // ����
        Hashtable myTable = new Hashtable();


        // ������ �߰�
        myTable.Add("first", "�ο���");
        myTable.Add("second", "���μ�");
        myTable.Add("third", "�̼���");
        myTable.Add("4", "��¿�");
        myTable.Add(5.2f, "�輺��");
        myTable.Add(0, 123);
        myTable.Add(false, 3441f);

        // ������ ��ȸ
        Debug.Log(myTable["first"]);
        Debug.Log(myTable["second"]);
        Debug.Log(myTable["third"]);
        Debug.Log(myTable[4]);
        Debug.Log(myTable[5.2f]);
        Debug.Log(myTable[0]);
        Debug.Log(myTable[false]);

        // �ݺ����� �̿��� ��ȸ
        for (int i = 0; i < myTable.Count; i++)
        {
            Debug.Log(myTable[i]);
        }

        Debug.Log($"--------------------------------------------------");
        foreach (var key in myTable.Keys)
        {
            Debug.Log(myTable[key]);
        }

        // ����
        myTable.Remove("first");

        // Ű�� �ִ��� �˻�
        // ContainsKey() �޼��带 �̿��� �ش� Ű�� ����ϴ� �����Ͱ� �ִ��� �˻�
        if (myTable.ContainsKey("first"))
        {
            Debug.Log("first key�� �ֽ��ϴ�.");
        }
        else
        {
            Debug.Log("first key�� �����ϴ�.");
        }


    }

}
