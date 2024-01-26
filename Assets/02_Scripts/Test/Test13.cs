using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test13 : MonoBehaviour
{
    public sbyte A;
    public sbyte B;
    public sbyte C;
    // Start is called before the first frame update
    void Start()
    {
        if (A == B && B == C && A == C)
        {
            Debug.Log($"{10000 + (A)*1000} 원");
        }
        else if (A == B && B != C)
        {
            Debug.Log($"{1000 + B*100} 원");
        }
        else if (B == C && C != A)
        {
            Debug.Log($"{1000 + B * 100} 원");
        }
        else if (A == C && B != A)
        {
            Debug.Log($"{1000 + A * 100} 원");
        }
        else
        {
            if (A > B && A > C)
            {
                Debug.Log($"{A * 100} 원");
            }
            else if (B > A && B > C)
            {
                Debug.Log($"{B * 100} 원");
            }
            else if (C > A && C > B)
            {
                Debug.Log($"{C * 100} 원");
            }
        }

    }

}
