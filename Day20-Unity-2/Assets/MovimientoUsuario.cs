using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoUsuario : MonoBehaviour
{
    public float velocidad = 5f;

    Rigidbody cuerpoRigid;
    
    // Start is called before the first frame update
    void Start()
    {
        cuerpoRigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveVertical = Input.GetAxis("Vertical");
        float moveHorizontal = Input.GetAxis("Horizontal");

        Vector3 movimiento = new Vector3(moveHorizontal, 0f, moveVertical);
        cuerpoRigid.AddForce(movimiento * velocidad);
    }
}
