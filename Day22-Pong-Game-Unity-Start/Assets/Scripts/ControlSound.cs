using UnityEngine;

public class ControlSound : MonoBehaviour
{
    public AudioSource sonidoRaqueta;
    public AudioSource sonidoPared;

    private void OnCollisionEnter2D(Collision collision)
    {
        if (collision.gameObject.name == "Raqueta1" || collision.gameObject.name == "Raqueta2")
        {
            sonidoRaqueta.Play();
        }
        else
        {
            sonidoPared.Play();
        }
    }
}
