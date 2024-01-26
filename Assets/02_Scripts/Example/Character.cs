using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Character : MonoBehaviour
{
    // ���� �̸��� �ǹ��ְ�
    // ǥ���: "�Ľ�Į���̽�" -> ù ���ڸ� �빮�ڷ� �����ϴ� �ܾ�


    // ������ ������
    [Header("�̸�")]
    public string CharacterName = "���δ�ī";
    [Header("����")]
    public string CharacterJob = "����";
    [Header("����")]
    public string CharacterNickName = "�ò����� ����";
    [Header("����")]
    public string CharacterSpecies = "����";
    [Header("���̸�")]
    public string PetName = "�巹��";    


    // ������ ������
    [Header("�̵��ӵ�")]
    public int MoveSpeed = 140;
    [Header("�α⵵")]
    public int PopularLevel = 516;
    [Header("ü��")]
    public int Health = 74884;
    [Header("������")]
    public int Jump = 150;
    [Header("���ݷ���")]
    public int AttackLevel = 8;

    // �Ǽ��� ������
    [Header("���ط�")]
    public float Damage = 159.40f;
    [Header("����")]
    public float Defense = 105.40f;
    [Header("���Ŵɷ�")]
    public float HideLevel = 134.50f;
    [Header("����ɷ�")]
    public float FlyLevel = 207.40f;
    [Header("��Ȱ��")]
    public float BreathLevel = 98.23f;



    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("�̸�: " + CharacterName);
        Debug.Log("����: " + CharacterJob);
        Debug.Log("����: " + CharacterNickName);
        Debug.Log("����: " + CharacterSpecies);
        Debug.Log("���̸�: " + PetName);

        Debug.Log("�̵��ӵ�: " + MoveSpeed);
        Debug.Log("�α⵵: " + PopularLevel);
        Debug.Log("ü��: " + Health);
        Debug.Log("������: " + Jump);
        Debug.Log("���ݷ���: " + AttackLevel);

        Debug.Log("���ط�: " + Damage);
        Debug.Log("����: " + Defense);
        Debug.Log("���Ŵɷ�: " + HideLevel);
        Debug.Log("����ɷ�: " + FlyLevel);
        Debug.Log("��Ȱ��: " + BreathLevel);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
