using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ����ü(struct)
// - Ŭ������ ������ ������ ������ �ִ�. 
// - Ŭ����ó�� �Ӽ�(����)�� �޼ҵ带 ���� �� �ִ�. 
// Ŭ������ ��ü�� �߻�ȭ�ϰ� ����� �� ������ �ְ�, 
// ����ü�� �پ��� �����͸� �ϳ��� ���� �Ϳ� �ǹ̰� �ִ�. 
// Ŭ������ ���� �����̰�, ����ü�� �� �����̴�.

public struct Point               // MonoBehaviour �����ֱ�
{
    public int X;
    public int Y;

    public Point (int x, int y)
    {
        X = x;
        Y = y;
    }
}
