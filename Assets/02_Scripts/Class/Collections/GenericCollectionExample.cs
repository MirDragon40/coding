using System.Collections;
using System.Collections.Generic;    // ���׸� �÷���
using UnityEngine;

public class GenericCollectionExample : MonoBehaviour
{
    // ���׸� �÷���
    // - ���� �÷����� ���� �ڽ�/��ڽ̿� ���� �������� ������ �ذ��� �ڷᱸ��
    // - ���׸��� ���� ����� �� Ÿ���� �����ȴ�.


    // Start is called before the first frame update
    void Start()
    {
        // ArrayList -> List<T>
        List<string> myList = new List<string>();
        myList.Add("�ο���");
        myList.Add("���μ�");

        // Hashtable -> Dictionary<TKey, TValue>
        Dictionary<string, int> myTable = new Dictionary<string, int>();
        myTable.Add("���μ�", 13);
        myTable.Add("�ο���", 23);
        myTable["�̼���"] = 22;

        // ���׸� �÷����� ���� ������ �ڽ�/��ڽ����κ��� ��� �� �ְ� ���ش�. 
        // List<int>�� int �ڷ����� �����͸� ó���ϹǷ� object ����ȯ�� ���Ͼ��.

        // ����ũ�μ���Ʈ������ �Ϲ� �÷����� ����� �������� �ʴ´�.
        // -> ���׸� �÷����� ���߿� �߰������Ƿ� ȣȯ���� ���� ���ܳ�������..




    }

}
