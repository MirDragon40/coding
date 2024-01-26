using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test04 : MonoBehaviour
{
    public short A;
    public short B;

    // Start is called before the first frame update
    void Start()
    {

        Debug.Log(A * (B % 100 % 10));  // A * (B의 1의 자리 수)  A * (B % 10)
        Debug.Log(A * (B % 100 - B % 100 % 10)/10);   // A * (B의 10의 자리 수)  A * (B / 10 % 10)
        Debug.Log(A * (B / 100));   // A * (B의 100의 자리 수)  A * (B / 100)
        Debug.Log(A * B);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
