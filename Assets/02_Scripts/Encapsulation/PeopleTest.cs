using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        People people = new People("������",25, 180.1f, "ENFP");
        people.SetAge(26);
        people.SetAge(-3);

        people.Height = -10;          // ������Ƽ set ������ ���
        Debug.Log(people.Height);     // ������Ƽ get ������ ���


        people.MBTI = "AAA"; // �ǽ�. MBTI�� ���ؼ� ������Ƽ�� �����غ�����.




        // people.GetAge = -3; // ���Ἲ�� ������!
        // ���Ἲ�̶� �������� ��Ȯ��, �ϰ���, ��ȿ��

        Debug.Log(people.GetName());    // Setname�� �ȸ������ν� �ܺο��� ������ ���ϵ��� �� ���� �ִ�.
        Debug.Log(people.GetAge());

    }

}
