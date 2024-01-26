using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test11 : MonoBehaviour
{
    public int H;
    public int M;

    void Start()
    {
        if (M < 45 && H != 0 )
        {
            Debug.Log($"{H - 1}:{59 - (44 - M)}");
        }
        else if (M < 45 && H == 0)
        {
            Debug.Log($"{23}:{59 - (44 - M)}");
        }

    }

}
