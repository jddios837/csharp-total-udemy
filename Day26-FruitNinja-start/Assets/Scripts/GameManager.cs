using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Define una categoria en inspector de UNITY
    [Header("Elementos del Puntaje")]
    public int puntaje;
    public int mejorPuntaje;
    public Text textoPuntaje;
    public Text textoMejorPuntaje;
    private string labelMejorPuntaje = "MejorPuntaje";

    [Header("Elementos Game Over")]
    public GameObject panelGameOver;
    public Text textoPuntajeFinal;
    public Text textoMejorPuntajePanel;

    private void PonerMejorPuntaje()
    {
        mejorPuntaje = PlayerPrefs.GetInt(labelMejorPuntaje);
        textoMejorPuntaje.text = "Mejor: " + mejorPuntaje.ToString();
    }
    private void Awake()
    {
        panelGameOver.SetActive(false);
        PonerMejorPuntaje();
    }

    public void AumentarPuntaje()
    {
        puntaje += 2;
        textoPuntaje.text = puntaje.ToString();

        if (puntaje > mejorPuntaje)
        {
            PlayerPrefs.SetInt(labelMejorPuntaje, puntaje);
            textoMejorPuntaje.text = "Mejor: " + puntaje.ToString();
            mejorPuntaje = puntaje;
        }
    }

    public void AlTocarBomba()
    {
        Time.timeScale = 0;
        panelGameOver.SetActive(true);
        textoPuntajeFinal.text = "Puntaje: " + puntaje.ToString();
        textoMejorPuntajePanel.text = "Mejor Puntaje: " + mejorPuntaje.ToString();
    }

    public void Reiniciar()
    {
        puntaje = 0;
        textoPuntaje.text = puntaje.ToString();
        Time.timeScale = 1;
        panelGameOver.SetActive(false);

        foreach (GameObject g in GameObject.FindGameObjectsWithTag("Interactivo"))
        {
            Destroy(g);
        }
    }
}
