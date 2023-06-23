using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PaswordValidatator : MonoBehaviour
{
    [SerializeField] private TMP_InputField passwordInput;
    [SerializeField] private TMP_InputField passwordRepInput;
    [SerializeField] private TMP_Text stateText;

    private void Awake()
    {
       // passwordRepInput.onValidateInput.addListener(OnValueChangedHandler);
        stateText.enabled = false;
    }

    private void OnValueChangedHandler(string PasswordRep)
    {
        var pasword = passwordInput.text;
        var isInCorrecRepeatPassword = pasword != PasswordRep;
        stateText.enabled = isInCorrecRepeatPassword;
        if (pasword != PasswordRep)
        {
            stateText.text = "no coinciden";
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
