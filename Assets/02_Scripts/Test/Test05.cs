using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Test05 : MonoBehaviour
{
    public float weight;
    public float height;


    // Start is called before the first frame update
    void Start()
    {
        float BMI = weight / (height/100 * height/100);
        Debug.Log(BMI);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
