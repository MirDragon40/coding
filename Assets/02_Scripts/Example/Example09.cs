using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example09 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 1. ������
        // 1-2. �Ǽ���: �Ҽ����� �ִ� ����
        // float, double. decimal

        float floatValue = 3.143243589723948798458928934343348f;      // 7�ڸ� ���е�
        double doubleValue = 3.1432435897239487984589289344343348f;   // 15�ڸ� ���е�
        decimal decimalValue = 3.143243589723948798458928343493348m;  // 29�ڸ� ���е�

        Debug.Log(floatValue);
        Debug.Log(doubleValue);
        Debug.Log(decimalValue);  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
