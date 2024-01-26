using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test01 : MonoBehaviour
{
    public int A;
    public int B;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(A + B);
        Debug.Log(A - B);
        Debug.Log(A * B);
        Debug.Log(A / B);
        Debug.Log(A % B);

    }
}
