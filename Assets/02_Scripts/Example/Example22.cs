using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example22 : MonoBehaviour
{
    void Start()
    {
        // ���� 1���� 10���� ����ϴ� for �ݺ���
        for (int i = 1; i <= 10; i++)
        {
            if (i == 0)
            {
                break;
            }
            if (i == 5)
            {
                continue;
                // continue: �ݺ������� �Ʒ� �ڵ���� ������ �ǳʶ۶� ���
                // -> �ݺ��� ����ϰ� �ٽ� ���� �ݺ��� �����Ѵ�.
            }

            Debug.Log(i);

        }

        // 1���� 100���� for �ݺ����� continue�� �̿��ؼ� ¦���� ����ϱ�

        // break: �ݺ��� ��Ͼȿ��� ������ �ߴ��ϰ� Ż���Ҷ� ����Ѵ�.
        // continue: �ݺ����� �ݺ��� �� �� ����ϰ� ���� �ݺ��� ������ �� ����Ѵ�.
        for (int i = 1; i <= 100; i++)
        {
            int a = i % 2;
            if (a != 0)
            {
                continue;
            }

            Debug.Log(i);
        }
    }

}
