using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UiIten : MonoBehaviour
{
    [SerializeField] private Image ItenImage;
    [SerializeField] private TMP_Text ItenText;

    public void SetInfo(string p_name, Sprite p_Sprite, Color itenColor)
    {
        ItenText.text = p_name;
        ItenImage.sprite = p_Sprite;
        ItenImage.color = itenColor;
    }

    
}
