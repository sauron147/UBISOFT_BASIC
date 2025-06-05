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
        Debug.Log("저의 이름은 " + name + " 입니다");
        Debug.Log($"저의 나이는 {age}살 입니다");
        Debug.Log($"저의 몸무게는 {weight}kg 입니다");
        Debug.Log($"저의 키는 {height}cm 입니다");
        Debug.Log("저의MBTI는" + MBTI + "입니다");
        Debug.Log("저의성별은" + gender + "입니다");
        Debug.Log("저의취미는" + hobby + "입니다");
        Debug.Log("제가 좋아하는색깔은" + favorite_color + "입니다");
        Debug.Log("제가 좋아하는 게임은" + favorite_game + "입니다");
        Debug.Log("제가 좋아하는 음식은" + favorite_food + "입니다");
    }
    public void SelfIntroduction(string _name, int _age)
    {
        Debug.Log("저의이름은" + _name + "입니다");
        Debug.Log($"저의나이는 {_age}살 입니다.");
    }

    public void SelfIntroduction(string _MBTI, string _gender, string _hobby, string _favorite_color,
        string _favorite_food, string _favorite_game, double _weight, double _height)
    {
        Debug.Log("저의MBTI는" + _MBTI + "입니다");
        Debug.Log("저의성별은" + _gender + "입니다");
        Debug.Log("저의취미는" + _hobby + "입니다");
        Debug.Log("제가 좋아하는 색깔은" + _favorite_color + "입니다");
        Debug.Log("제가 좋아하는 게임은" + _favorite_game + "입니다");
        Debug.Log("제가 좋아하는 음식은" + _favorite_food + "입니다");
        Debug.Log($"저의몸무게는 {_height}kg 입니다.");
        Debug.Log($"저의키는 {_weight}cm 입니다.");
    }
} 
