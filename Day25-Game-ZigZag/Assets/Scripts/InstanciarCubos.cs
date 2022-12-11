using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciarCubos : MonoBehaviour
{
    public Transform prefab;

    private int contador = 0;

    void Start()
    {
        // Invoca una funcion cada 3s y se repite luego de 1s
        // InvokeRepeating("CrearCuboNuevo", 3f, 1f);
        
        // Invoca una funcion luego de 3s
        Invoke("CrearCuboNuevo", 3f);
    }

    public void CrearCuboNuevo()
    {
        Instantiate(prefab, new Vector3(-10 + contador * 3.0f, 0, 0), Quaternion.identity);
        contador++;

        if (contador >= 5)
        {
            CancelInvoke();
        }
    }
}
