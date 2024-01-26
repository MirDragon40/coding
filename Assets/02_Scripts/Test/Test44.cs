using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Test44 : MonoBehaviour
{
    public string Pell;
    void Start()
    {
        if (Pell.Length % 2 == 0)
        {
            int answer1 = 1;
            for (int i = 0; i <= Pell.Length / 2 - 1; i++)
            {
               
                bool isPell = Pell[i] == Pell[Pell.Length-1 - i];
                if (isPell == true)
                {
                    continue;
                }
                if (isPell == false)
                {
                    answer1 = 0;
                    break;
                }


            }
            Debug.Log(answer1);

        }

        if (Pell.Length % 2 != 0)
        {
            int answer2 = 1;
            for (int i = 0; i <= (Pell.Length - 1) / 2 - 1; i++)
            {
                bool isPell = Pell[i] == Pell[Pell.Length-1 - i];

                if (isPell == true)
                {
                    continue;
                }
                if (isPell == false)
                {
                    answer2 = 0;
                    break;
                }

            }
            Debug.Log(answer2);
        }

    }

}
