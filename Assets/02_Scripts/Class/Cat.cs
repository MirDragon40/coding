using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat
{
    public string Name;
    public int Age;
    public string FurColor;
    public string Species;
    public float Weight;
    public bool LikesWater;
   

    public Cat()
    {

    }

    public Cat(string name, int age, string furColor, string species, float weight, bool likesWater)
    {
        Name = name;
        Age = age;
        FurColor = furColor;
        Species = species;
        Weight = weight;
        LikesWater = likesWater;
    }

    public void Run()
    {
        Debug.Log($"{Name}��(��) �ٱ� �����ߴ�!");
    }
    public void Sleep()
    {
        Debug.Log($"{Name}��(��) �ῡ �������� �ϰ��ִ�.");
    }
    public void Cry()
    {
        Debug.Log($"{Name}��(��) ����ִ�.");
    }
    public void Grooming(Cat otherCat)
    {
        Debug.Log($"{Name}��(��) {otherCat.Name}(��)�� {otherCat.FurColor}�� ���� �Ӱ� �ִ�.");
    }

    public void Grooming(Dog dog)
    {
        Debug.Log($"{Name}��(��) {dog.Name}(��)�� {dog.FurColor}�� ���� �Ӱ� �ִ�.");
    }

}
