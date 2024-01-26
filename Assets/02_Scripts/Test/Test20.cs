using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test20 : MonoBehaviour
{
    public int N = 6;


    void Start()
    {

        for (int i = 1; i <= N; i++)
        {
            string str = "";
           
            
            for(int k = 0; k < N; k++)
            {
                if(k < N - i)
                {
                    // 빈칸 더해주고
                    str += "  ";
                }
                else
                {
                    // 별 더해주고
                    str += "*";
                }

               
            }



            Debug.Log(str);

        }


    }

}
