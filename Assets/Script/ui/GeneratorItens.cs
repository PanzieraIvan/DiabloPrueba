using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public struct ItenData
{
    public string itennave;
    public Sprite ItenSprite;
    public Color iitenColor;
    public string Itendescription;
}

public class GeneratorItens : MonoBehaviour
{
    [SerializeField] private UiIten itenPrefab;
    [SerializeField] private List<ItenData> itenDatas;
    [SerializeField] private RectTransform Parent;

    private void Awake()
    {
        foreach (var item in itenDatas)
        {
            var l_iten =  Instantiate(itenPrefab, Parent);
            l_iten.SetInfo(item.itennave, item.ItenSprite, item.iitenColor);
        }
    }


}
