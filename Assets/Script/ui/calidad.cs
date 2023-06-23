using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class calidad : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public int caalidad;
    // Start is called before the first frame update
    void Start()
    {
        caalidad = PlayerPrefs.GetInt("numeroDeCalidad", 3);
        dropdown.value = caalidad;
        AjustarCalidad();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AjustarCalidad()
    {
        QualitySettings.SetQualityLevel(dropdown.value);
        PlayerPrefs.SetInt("numeroDeCalidad", dropdown.value);
        caalidad = dropdown.value;
    }
}
