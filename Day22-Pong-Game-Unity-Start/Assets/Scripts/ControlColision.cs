using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlColision : MonoBehaviour
{
    public MoveBall moveBall;
    public ControlPuntaje controlPuntaje;

    void ReboteConRaqueta(Collision2D c)
    {
        Vector3 posicionPelota = this.transform.position;
        Vector3 posicionRaqueta = c.gameObject.transform.position;
        float alturaRaquetaPelota = c.collider.bounds.size.y;

        float x;
        if (c.gameObject.name == "Raqueta1")
        {
            x = 1;
        }
        else
        {
            x = -1;
        }
        
        float y = (posicionPelota.y - posicionRaqueta.y) / alturaRaquetaPelota;

        this.moveBall.AumetarContadorGolpes();
        this.moveBall.MovimientoPelota(new Vector2(x, y));
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Raqueta1" || col.gameObject.name == "Raqueta2")
        {
            this.ReboteConRaqueta(col);
        } else if (col.gameObject.name == "ParedIzquierda")
        {
            this.controlPuntaje.GolJugador1();
        } 
        else if (col.gameObject.name == "ParedDerecha")
        {
            this.controlPuntaje.GolJugador2();
        }
    }
}
