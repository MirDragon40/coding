using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test19 : MonoBehaviour
{
    public int N;

    void Start()
    {
        string a = "";
        /**
        Debug.Log(a);   // *
        a = a + "*";
        Debug.Log(a);   // **
        **/
        for (int i = 1; i <= N; i++)
        {
            a = a + "*";
            Debug.Log(a);
        }
        /**
         *   
         *   using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test19 : MonoBehaviour
{
            public int N = 5;

            void Start()
            {
                for(int i = 1; i <= N; i++)
                {
                    string star = "";

                    for(int j = 0; j < i; j++)
                    {
                        star += "*";
                    }

                    Debug.Log(star);
                }
            }
}

         **/
    }
}
