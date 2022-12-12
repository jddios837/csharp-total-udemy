using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ControlPersonaje : MonoBehaviour
{
    public Transform comienzoRayo;
    public GameObject efectoCristal;
    private Animator animator;
    private Rigidbody rb;
    private bool caminarDerecha = true;
    private GameManager gameManager;
    
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();

        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && gameManager.juegoIniciado)
        {
            CambiarDireccion();
        }

        RaycastHit contacto;
        if (!Physics.Raycast(comienzoRayo.position, -transform.up, out contacto, Mathf.Infinity))
        {
            animator.SetTrigger("Cayendo");
        }

        if (transform.position.y < -2f)
        {
            gameManager.FinalizarJuego();
        }
    }

    private void FixedUpdate()
    {
        if (!gameManager.juegoIniciado)
        {
            return;
        }
        else
        {
            animator.SetTrigger("ComenzoJuego");
        }

        rb.transform.position = transform.position + transform.forward * 2 * Time.deltaTime;
    }
    
    private void CambiarDireccion()
    {
        caminarDerecha = !caminarDerecha;

        transform.rotation = caminarDerecha ? 
            Quaternion.Euler(0,45,0) : 
            Quaternion.Euler(0,-45,0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Cristal")
        {
            gameManager.AumentarPuntaje();

            GameObject g = Instantiate(efectoCristal, comienzoRayo.transform.position, Quaternion.identity);
            Destroy(g, 2);
            Destroy(other.GameObject());
        }
    }
}
