using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    public float velocidadMovimient;
    public float velocidadExtraPorGolpe;
    public float velocidadExtraMaxima;

    private int contadorGolpe;

    private void Start()
    {
        StartCoroutine(this.IniciarPelota());
    }

    public IEnumerator IniciarPelota(bool comienzaJugador1 = true)
    {
        this.PosicionPelota(comienzaJugador1);
        
        this.contadorGolpe = 0;

        yield return new WaitForSeconds(2);

        if (comienzaJugador1)
        {
            this.MovimientoPelota(new Vector2(-1, 0));
        }
        else
        {
            this.MovimientoPelota(new Vector2(1, 0));
        }
    }

    public void MovimientoPelota(Vector2 dir)
    {
        dir = dir.normalized;
        float velocidad = velocidadMovimient + contadorGolpe * velocidadExtraPorGolpe;

        Rigidbody2D rigidbody2D = this.gameObject.GetComponent<Rigidbody2D>();
        rigidbody2D.velocity = dir * velocidad;
    }

    public void AumetarContadorGolpes()
    {
        if (this.contadorGolpe * this.velocidadExtraPorGolpe <= this.velocidadExtraMaxima)
        {
            this.contadorGolpe++;
        }
    }

    void PosicionPelota(bool comienzaJugador1)
    {
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        this.gameObject.transform.localPosition = comienzaJugador1 ? 
            new Vector3(-100, 0, 0) : 
            new Vector3(100, 0, 0);
    }
}
