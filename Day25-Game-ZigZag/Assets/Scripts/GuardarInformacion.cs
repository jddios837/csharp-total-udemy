using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardarInformacion : MonoBehaviour
{
    private int numero = 0;
    // Start is called before the first frame update
    void Start()
    {
        print("El numero almacenado es: " + ObtenerNumero());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            numero++;
            if (numero > ObtenerNumero())
            {
                PlayerPrefs.SetInt("MiNumero", numero);
                print(numero);
            }
        }
    }

    int ObtenerNumero()
    {
        int miNumero = PlayerPrefs.GetInt("MiNumero", 0);
        return miNumero;
    }
}
