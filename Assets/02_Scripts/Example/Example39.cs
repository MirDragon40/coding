using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example39 : MonoBehaviour
{
    // ���� ���� ���� (Call by Value)
    // - ������ ����κ��� ���� �����ؼ� ����.

    // ������ ���� ���� (Call by Reference)
    // - ���� �����ϴ� ���� �ƴ� ���� ������ ����(���߾� ����.)
    // - ���� ������ ���� ���̹Ƿ� ���� �����ϸ� ���� ������ ���� ����ȴ�.
    // - ��� ���: �Ű� ���� �տ� ref Ű���� ���.
    void Swap(ref int num1, ref int num2)
    {
        int tempNum = num1;
        num1 = num2;
        num2 = tempNum;

    }
    
    // ref Ű����� �Լ� ���ο��� ���� ������ ���� �������� �ʾƵ� ������
    // out Ű����� �Լ� ���ο��� ���� �����ǰ��� �����ؾ� �Ѵ�.
    // out�� ref�� ��������� �������� �Ǽ��� �ٿ��ش�. -> � ��쿡?

    void Test(out int num)   // �Ǽ��� �ٿ��ش�.
    {
       num = 3;
    }

    void Start()
    {
        int num1 = 3;
        int num2 = 9;

        Debug.Log($"�ٲ�� ��: num1 = {num1}, num2 = {num2}");

        Swap(ref num1, ref num2);  // reference(�����ϴ�) ���� ���� 'ref'
                                   
                                   // 'ref'�� ���� �������ִ� ���� �ƴ϶� �ٸ� ���� ����.
                                   // C������ ref��  point��� �θ���.


        //int[] nums = { num1, num2 };
        //num1 = nums[1];
        //num2 = nums[0];

        Debug.Log($"�ٲ� ��: num1 = {num1}, num2 = {num2}");

        Test(out num1);
    }

}
