using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        People people = new People("�̼���",25);
        people.SetAge(26);
        people.SetAge(-3);    // ���Ἲ�� ������!
        // ���Ἲ�̶� �������� ��Ȯ��, �ϰ���, ��ȿ��

        Debug.Log(people.GetName());    // Setname�� �ȸ������ν� �ܺο��� ������ ���ϵ��� �� ���� �ִ�.
        Debug.Log(people.GetAge());

    }

}
