using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test08 : MonoBehaviour
{
    public sbyte score;

    void Start()
    {

        // ��� 1 (�б⹮ ��� X)
        if (score <= 100 && score >= 90)
        {
            Debug.Log("A");
        }
        else if (score <= 89 && score >= 80)
        {
            Debug.Log("B");
        }
        else if (score <= 79 && score >= 70)
        {
            Debug.Log("C");
        }
        else if (score <= 69 && score >= 60)
        {
            Debug.Log("D");
        }
        else
        {
            Debug.Log("F");
        }

        // ��� 2 (�б⹮ ���)
        int newScore = score / 10;
        switch (newScore)
        {
            case 10:
                {
                    Debug.Log("A");
                    break;
                }

            case 9:
                {
                    Debug.Log("A");
                    break;
                }
            case 8:
                {
                    Debug.Log("B");
                    break;
                }
            case 7:
                {
                    Debug.Log("C");
                    break;
                }
            case 6:
                {
                    Debug.Log("D");
                    break;
                }
            default:
                {
                    Debug.Log("F");
                    break;
                }
        }

        // ������ Ǯ�� 3

        switch(score)
        {
            case >= 90:
                {
                    Debug.Log("A");
                    break;
                }
            case >= 80:
                {
                    Debug.Log("B");
                    break;
                }
            case >= 70:
                {
                    Debug.Log("C");
                    break;
                }
            case >= 60:
                {
                    Debug.Log("D");
                    break;
                }
        }


    }
}
