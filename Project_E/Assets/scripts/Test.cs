using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Analytics;

using TMPro;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    private string name = "KJH";
    private string MBTI = "INTP";
    private string gender = "Man";
    private string hobby = "movie";
    private string favorite_food = "spaghetti";
    private string favorite_color = "black";
    private string favorite_game = "bioshock";
    private int age = 26;
    private double height = 178.2;
    private double weight = 72.1;
    void Start()
    {
        SelfIntroduction();
    }
    public void SelfIntroduction()
    {
        Debug.Log("���� �̸��� " + name + " �Դϴ�");
        Debug.Log($"���� ���̴� {age}�� �Դϴ�");
        Debug.Log($"���� �����Դ� {weight}kg �Դϴ�");
        Debug.Log($"���� Ű�� {height}cm �Դϴ�");
        Debug.Log("����MBTI��" + MBTI + "�Դϴ�");
        Debug.Log("���Ǽ�����" + gender + "�Դϴ�");
        Debug.Log("������̴�" + hobby + "�Դϴ�");
        Debug.Log("���� �����ϴ»�����" + favorite_color + "�Դϴ�");
        Debug.Log("���� �����ϴ� ������" + favorite_game + "�Դϴ�");
        Debug.Log("���� �����ϴ� ������" + favorite_food + "�Դϴ�");
    }
    public void SelfIntroduction(string _name, int _age)
    {
        Debug.Log("�����̸���" + _name + "�Դϴ�");
        Debug.Log($"���ǳ��̴� {_age}�� �Դϴ�.");
    }

    public void SelfIntroduction(string _MBTI, string _gender, string _hobby, string _favorite_color,
        string _favorite_food, string _favorite_game, double _weight, double _height)
    {
        Debug.Log("����MBTI��" + _MBTI + "�Դϴ�");
        Debug.Log("���Ǽ�����" + _gender + "�Դϴ�");
        Debug.Log("������̴�" + _hobby + "�Դϴ�");
        Debug.Log("���� �����ϴ� ������" + _favorite_color + "�Դϴ�");
        Debug.Log("���� �����ϴ� ������" + _favorite_game + "�Դϴ�");
        Debug.Log("���� �����ϴ� ������" + _favorite_food + "�Դϴ�");
        Debug.Log($"���Ǹ����Դ� {_height}kg �Դϴ�.");
        Debug.Log($"����Ű�� {_weight}cm �Դϴ�.");
    }
} 
