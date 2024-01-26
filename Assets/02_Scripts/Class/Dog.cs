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
        Debug.Log($"{Name}��(��) �ٱ� �����ߴ�.");
    }
    public void Sleep()
    {
        Debug.Log($"{Name}��(��) �ῡ �������� �ϰ� �ִ�.");
    }
    public void Bark()
    {
        Debug.Log($"{Name}��(��) ¢�� �����ߴ�.");
    }
    public void HoldBack(Dog otherDog)
    {
        Debug.Log($"{Name}��(��) {otherDog.Name}��(��) ����´�.");
    }
    public void HoldBack(Cat catName)
    {
        Debug.Log($"{Name}��(��) {catName.Name}��(��) ����´�.");
    }
}
