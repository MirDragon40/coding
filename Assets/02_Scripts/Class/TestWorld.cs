using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestWorld : MonoBehaviour
{
    void Start()
    {
        Cat cat1 = new Cat();
        cat1.Name = "����";
        cat1.Age = 4;
        cat1.FurColor = "����";
        cat1.Species = "�丣�þ�";
        cat1.Weight = 24.5f;
        cat1.LikesWater = true;
        cat1.Run();
        cat1.Sleep();
        cat1.Cry();

        Cat cat2 = new Cat("�߿�", 7, "�Ķ�", "����ũ��", 30.7f, false);
        cat2.Run();
        cat2.Sleep();
        cat2.Cry();

        Dog dog1 = new Dog();
        dog1.Name = "�۸�";
        dog1.Age = 5;
        dog1.FurColor = "ȸ";
        dog1.Species = "�ú����� �㽺Ű";
        dog1.Weight = 43.6f;
        dog1.DidWalk = true;
        dog1.Run();
        dog1.Sleep();
        dog1.Bark();

        Dog dog2 = new Dog("�鱸", 2, "Ȳ��", "������", 50.1f, false);
        dog2.Run();
        dog2.Sleep();
        dog2.Bark();

        cat1.Grooming(cat2);
        cat2.Grooming(dog1);

        dog1.HoldBack(dog2);
        dog2.HoldBack(cat1);

    }
}
