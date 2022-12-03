using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPared : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
