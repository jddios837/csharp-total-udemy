using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SeguimientoPuntaje : MonoBehaviour
{
    public Transform objetivo;

    private Vector3 diferencia;
    private GameManager gameManager;

    // Awake is called before the first frame update
    void Awake()
    {
        diferencia = transform.position - objetivo.position;
        gameManager = FindObjectOfType<GameManager>();
    }

    private void LateUpdate()
    {
        transform.position = objetivo.position + diferencia;
        // Text label = this.GetComponent<Text>();
        // label.text = this.gameManager.puntaje.ToString();
    }
}
