using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaOpciones : MonoBehaviour
{
    public ControladorDeOpciones panelDeOpciones;
    // Start is called before the first frame update
    void Start()
    {
        panelDeOpciones = GameObject.FindGameObjectWithTag("Options").GetComponent<ControladorDeOpciones>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            MostrarOpciones();
        }
    }
    public void MostrarOpciones()
    {
        panelDeOpciones.PantallaOpciones.SetActive(true);
    }
}
