using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Fruta : MonoBehaviour
{
    public GameObject prefabFrutaCortada;

    public void CrearFrutaCortada()
    {
        GameObject inst = Instantiate(prefabFrutaCortada, transform.position, transform.rotation);

        Rigidbody[] rbsDeCortados = inst.transform.GetComponentsInChildren<Rigidbody>();

        foreach (var r in rbsDeCortados)
        {
            r.transform.rotation = Random.rotation;
            r.AddExplosionForce(Random.Range(500,1000), transform.position, 5f);
            // r.AddExplosionForce(Random.Range((500f,1000f), transform.position, 5f));
        }
        
        FindObjectOfType<GameManager>().AumentarPuntaje();
        
        Destroy(gameObject);
        Destroy(inst.gameObject, 5);
    }

    // Update is called once per frame
    // void Update()
    // {
    //     if (Input.GetKeyDown(KeyCode.Escape))
    //     {
    //         CrearFrutaCortada();
    //     } 
    // }

    private void OnTriggerEnter2D(Collider2D col)
    {
        Espada e = col.GetComponent<Espada>();

        if (!e)
        {
            return;
        }
        
        CrearFrutaCortada();
    }
}
