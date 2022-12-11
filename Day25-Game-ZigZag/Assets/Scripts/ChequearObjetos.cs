using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChequearObjetos : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        // verificar si nuestro raton toca algo
        Ray rayo = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit tocado;

        if (Physics.Raycast(rayo, out tocado, 100f))
        {
            print("Contacto con " + tocado.collider.gameObject.name);
        }
        else
        {
            print("No tocamos nada");
        }

        // Codigo para verificar si un elemento toca algo
        // RaycastHit tocado;
        //
        // if (Physics.Raycast(transform.position, -Vector3.up, out tocado, 100f))
        // {
        //     print("Tocamos algo a " + tocado.transform.position);
        // }
        // else
        // {
        //     print("No he visto nada");
        // }
    }
}
