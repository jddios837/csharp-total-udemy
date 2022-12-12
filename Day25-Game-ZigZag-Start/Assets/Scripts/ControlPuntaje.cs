using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlPuntaje : MonoBehaviour
{
    public GameObject textoPuntaje1;
    private GameManager gameManager;

    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void FixedUpdate()
    {
        Text label = this.textoPuntaje1.GetComponent<Text>();
        label.text = gameManager.puntaje.ToString();
    }
}
