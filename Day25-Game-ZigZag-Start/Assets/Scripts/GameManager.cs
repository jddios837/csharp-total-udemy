using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool juegoIniciado;
    public int puntaje;
    public Text textoPuntaje;
    public Text puntajeMaximoTexto;

    private string tagPM = "PuntajeMaximo";
    private string textoMejorPuntaje = "Mejor: ";

    private void Awake()
    {
        puntajeMaximoTexto.text = textoMejorPuntaje + ObtenerPuntajeMaximo().ToString();
    }

    public void IniciarJuego()
    {
        juegoIniciado = true;
        FindObjectOfType<Ruta>().IniciarConstruccion();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            IniciarJuego();
        }
    }

    public void FinalizarJuego()
    {
        SceneManager.LoadScene(0);
    }

    public void AumentarPuntaje()
    {
        puntaje++;
        textoPuntaje.text = puntaje.ToString();

        if (puntaje > ObtenerPuntajeMaximo())
        {
            PlayerPrefs.SetInt(tagPM, puntaje);
            puntajeMaximoTexto.text = textoMejorPuntaje + puntaje.ToString();
        }
    }

    public int ObtenerPuntajeMaximo()
    {
        int i = PlayerPrefs.GetInt(tagPM);
        return i;
    }
}
