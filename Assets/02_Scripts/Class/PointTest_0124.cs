using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointTest_0124 : MonoBehaviour
{
    void Start()
    {
        // ����ü�� new Ű���带 ������� �ʾƵ� ������ ����/��� �� �� �ִ�.
        // ��� ���� ��� �Ӽ�(����)�� �ʱ�ȭ ����� ����� �� �ִ�.
        Point point1 = new Point(3, 7);
        point1.X = 3;
        point1.Y = 7;
        Debug.Log($"x: {point1.X}, y: {point1.Y}");

        Point point2 = new Point(12, 5);
        Debug.Log($"x: {point2.X}, y: {point2.Y}");

        point2 = point1;
        point2.X = 16;
        Debug.Log("-----------���� ��-----------");


        Debug.Log($"x: {point1.X}, y: {point1.Y}");
        Debug.Log($"x: {point2.X}, y: {point2.Y}");

    }
}
