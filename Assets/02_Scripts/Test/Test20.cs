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
                    // ��ĭ �����ְ�
                    str += "  ";
                }
                else
                {
                    // �� �����ְ�
                    str += "*";
                }

               
            }



            Debug.Log(str);

        }


    }

}
