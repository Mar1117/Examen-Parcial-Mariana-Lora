using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scrpt : MonoBehaviour
{
    private int seleccionIA;
    [SerializeField] public TMP_Text IATexto;
    [SerializeField] public TMP_Text PlayerTexto;
    private imputUsuario;

    // Start is called before the first frame update
    void Start()
    {
        seleccionIA = Random.Range(1,4);
        IATexto.text = "IA lista";
    }

    // Update is called once per frame
    void Update()
    {
        void selection(int selection);
        {
            imput usuario = seleccion;
            if (usuario == 1)
            {
                PlayerTexto.Text = "Votos = 1";
            }
            if (usuario == 2)
            {
                PlayerTexto.Text = "Votos = 2";
            }
            if (usuario == 3)
            {
                PlayerTexto.Text = "Votos = 3";
            }
            if (seleccionIA == 1 && imputUsuario == 1)
            {
                IATexto.text = ("Empate");
            }
        }
    }
}
