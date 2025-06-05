using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BUTT : MonoBehaviour
{
    public TextMeshProUGUI Txt_Text;   

    
    public void OnClickButton(string value)
    {
        Txt_Text.text = value;
    }
}