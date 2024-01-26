using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test02 : MonoBehaviour
{
    public sbyte A;
    public sbyte B;


    // Start is called before the first frame update
    void Start()
    {
        sbyte C = A;
        sbyte D = B;
        A = D;
        B = C;

        


        Debug.Log(A);
        Debug.Log(B);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
