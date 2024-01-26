using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog
{

    public string Name;
    public int Age;
    public string FurColor;
    public string Species;
    public float Weight;
    public bool DidWalk;

    public Dog()
    {

    }

    public Dog(string name, int age, string furColor, string species, float weight, bool didWalk)
    {
        Name = name;
        Age = age;
        FurColor = furColor;
        Species = species;
        Weight = weight;
        DidWalk = didWalk;
    }

    public void Run()
    {
        Debug.Log($"{Name}이(가) 뛰기 시작했다.");
    }
    public void Sleep()
    {
        Debug.Log($"{Name}이(가) 잠에 들으려고 하고 있다.");
    }
    public void Bark()
    {
        Debug.Log($"{Name}이(가) 짖기 시작했다.");
    }
    public void HoldBack(Dog otherDog)
    {
        Debug.Log($"{Name}이(가) {otherDog.Name}을(를) 물어온다.");
    }
    public void HoldBack(Cat catName)
    {
        Debug.Log($"{Name}이(가) {catName.Name}을(를) 물어온다.");
    }
}
