using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;  

public class Gacha : MonoBehaviour
{
    
    public TextMeshProUGUI Txt_Result;

   
    List<string> characterList = new List<string>();

    
    string[] five = { "★한세세세웅★" };

    // 천장 카운트
    int Count = 0;
    int Limit = 50;

    private void Start()
    {
        
        characterList.Add("한세웅");
        characterList.Add("목승환");
        characterList.Add("문혜준");
        characterList.Add("양승화");
        characterList.Add("김재협");
        characterList.Add("★★두세웅");
    }

    public void PullTen()
    {
        
        Txt_Result.text = "10연차 결과";

       
        for (int i = 1; i <= 10; i++)
        {
            if (Count >= Limit)
            {
               
                int fiveIndex = Random.Range(0, five.Length);
                string pick = five[fiveIndex];

                Txt_Result.text += $"[{i}번째 뽑기] ★천장발동★ {pick} 당첨!";
                Count = 0;  
            }
            else
            {
                
                int randValue = Random.Range(1, 101); 

                if (randValue <= 1)
                {
                    Txt_Result.text += $"[{i}번째 뽑기] ★★★삼세웅 당첨! (1%)";
                    Count = 0;
                }
                else if (randValue <= 10)
                {
                    Txt_Result.text += $"[{i}번째 뽑기] ★★두세웅 당첨! (9%)";
                    Count++;
                }
                else
                {
                    int index = Random.Range(0, characterList.Count);
                    string pick = characterList[index];

                    Txt_Result.text += $"[{i}번째 뽑기] 일반 캐릭터 당첨! {pick}";
                    Count++;
                }
            }
        }

        // 3️⃣ 마지막에 현재 스택 표시
        Txt_Result.text += $"현재 스택: {Count}";
    }
}
