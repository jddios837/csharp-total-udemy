using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPersonaje : MonoBehaviour
{
    public Transform comienzoRayo;
    private Animator animator;
    private Rigidbody rb;
    private bool caminarDerecha = true;
    
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CambiarDireccion();
        }

        RaycastHit contacto;
        if (!Physics.Raycast(comienzoRayo.position, -transform.up, out contacto, Mathf.Infinity))
        {
            animator.SetTrigger("Cayendo");
        }
    }

    private void FixedUpdate()
    {
        rb.transform.position = transform.position + transform.forward * 2 * Time.deltaTime;
    }
    
    private void CambiarDireccion()
    {
        caminarDerecha = !caminarDerecha;

        transform.rotation = caminarDerecha ? 
            Quaternion.Euler(0,45,0) : 
            Quaternion.Euler(0,-45,0);
    }
    
}
