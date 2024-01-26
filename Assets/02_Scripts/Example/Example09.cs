using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example09 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 1. 숫자형
        // 1-2. 실수형: 소수점이 있는 숫자
        // float, double. decimal

        float floatValue = 3.143243589723948798458928934343348f;      // 7자리 정밀도
        double doubleValue = 3.1432435897239487984589289344343348f;   // 15자리 정밀도
        decimal decimalValue = 3.143243589723948798458928343493348m;  // 29자리 정밀도

        Debug.Log(floatValue);
        Debug.Log(doubleValue);
        Debug.Log(decimalValue);  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
