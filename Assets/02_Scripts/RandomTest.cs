using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTest : MonoBehaviour
{
    

    void Start()
    {
        // UnityEngine.Random Ŭ����: ���� ������ �����ִ� Ŭ����
        // ����: ���ǵ� ���� ������ �������� ����� �� ( = ������ )


        // Debug.Log(UnityEngine.Random.Range(0, 1));
        // ó�� ����ȭ�� ���� ���� ���� ->  �õ尪
        // �ι�°�� ����� �� ������ �õ尪�� �˰����� ����Ѵ�.
        UnityEngine.Random.InitState(13);
        Debug.Log(UnityEngine.Random.Range(0, 100));
        


    }
}
  