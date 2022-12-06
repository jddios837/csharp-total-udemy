using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSonido : MonoBehaviour
{
    public AudioSource miMusica;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (miMusica)
            {
                if (miMusica.isPlaying)
                {
                    miMusica.Pause();
                }
                else
                {
                    miMusica.Play();
                }
            }
        }
    }
}
