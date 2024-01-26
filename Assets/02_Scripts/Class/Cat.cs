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
        Debug.Log($"{Name}이(가) 뛰기 시작했다!");
    }
    public void Sleep()
    {
        Debug.Log($"{Name}이(가) 잠에 들으려고 하고있다.");
    }
    public void Cry()
    {
        Debug.Log($"{Name}이(가) 울고있다.");
    }
    public void Grooming(Cat otherCat)
    {
        Debug.Log($"{Name}이(가) {otherCat.Name}(이)의 {otherCat.FurColor}색 털을 핥고 있다.");
    }

    public void Grooming(Dog dog)
    {
        Debug.Log($"{Name}이(가) {dog.Name}(이)의 {dog.FurColor}색 털을 핥고 있다.");
    }

}
