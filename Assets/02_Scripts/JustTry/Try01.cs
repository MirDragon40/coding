using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Try01 : MonoBehaviour
{


    void Start()
    {
        string food = "Apple";
        string animal = "Lion";
        string nickName = string.Empty;

        nickName = "�г���:" + food + animal;
        Debug.Log(nickName);

        nickName = string.Format("�г���: {0}{1}", food, animal);
        Debug.Log(nickName);

        nickName = $"{food}{animal}";
    }

}
