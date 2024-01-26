using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Character : MonoBehaviour
{
    // 변수 이름은 의미있게
    // 표기법: "파스칼케이스" -> 첫 글자를 대문자로 시작하는 단어


    // 문자형 데이터
    [Header("이름")]
    public string CharacterName = "베로니카";
    [Header("직업")]
    public string CharacterJob = "명사수";
    [Header("별명")]
    public string CharacterNickName = "시끄러운 닌자";
    [Header("종족")]
    public string CharacterSpecies = "엘프";
    [Header("펫이름")]
    public string PetName = "드레곤";    


    // 정수형 데이터
    [Header("이동속도")]
    public int MoveSpeed = 140;
    [Header("인기도")]
    public int PopularLevel = 516;
    [Header("체력")]
    public int Health = 74884;
    [Header("점프력")]
    public int Jump = 150;
    [Header("공격레벨")]
    public int AttackLevel = 8;

    // 실수형 데이터
    [Header("피해량")]
    public float Damage = 159.40f;
    [Header("방어력")]
    public float Defense = 105.40f;
    [Header("은신능력")]
    public float HideLevel = 134.50f;
    [Header("비행능력")]
    public float FlyLevel = 207.40f;
    [Header("폐활량")]
    public float BreathLevel = 98.23f;



    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("이름: " + CharacterName);
        Debug.Log("직업: " + CharacterJob);
        Debug.Log("별명: " + CharacterNickName);
        Debug.Log("종족: " + CharacterSpecies);
        Debug.Log("펫이름: " + PetName);

        Debug.Log("이동속도: " + MoveSpeed);
        Debug.Log("인기도: " + PopularLevel);
        Debug.Log("체력: " + Health);
        Debug.Log("점프력: " + Jump);
        Debug.Log("공격레벨: " + AttackLevel);

        Debug.Log("피해량: " + Damage);
        Debug.Log("방어력: " + Defense);
        Debug.Log("은신능력: " + HideLevel);
        Debug.Log("비행능력: " + FlyLevel);
        Debug.Log("폐활량: " + BreathLevel);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
