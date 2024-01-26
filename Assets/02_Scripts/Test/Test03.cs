using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test03 : MonoBehaviour
{
    public ushort A;
    public ushort B;
    public ushort C;


    void Start()
    {
        Debug.Log((A + B) % C);
        Debug.Log(((A % C) + (B % C)) % C);
        Debug.Log((A*B) % C);
        Debug.Log(((A % C) * (B % C)) % C);

    }


    void Update()
    {
        
    }
}
