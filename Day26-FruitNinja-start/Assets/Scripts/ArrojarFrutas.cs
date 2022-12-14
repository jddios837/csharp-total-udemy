using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class ArrojarFrutas : MonoBehaviour
{
    public GameObject[] frutasParaArrojar;
    public GameObject bombaParaArrojar;

    public float esperaMinima = 0.3f;
    public float esperaMaxima = 1f;
    public float fuerzaMinima = 12;
    public float fuerzaMaxima = 17;
    public Transform[] lugaresLanzamiento;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Arrojador());
        
    }

    public IEnumerator Arrojador()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(esperaMinima, esperaMaxima));

            Transform t = lugaresLanzamiento[Random.Range(0, lugaresLanzamiento.Length)];

            GameObject go = null;

            float p = Random.Range(0, 100);
            
            if (p < 10)
            {
                go = bombaParaArrojar;
            }
            else
            {
                go = frutasParaArrojar[Random.Range(0, frutasParaArrojar.Length)];
            }
            
            GameObject fruta = Instantiate(go, t.position, t.rotation);
            
            fruta
                .GetComponent<Rigidbody2D>()
                .AddForce(t.transform.up * Random.Range(fuerzaMinima, fuerzaMaxima), 
                    ForceMode2D.Impulse);
            
            print("Fruta arrojada");
            
            Destroy(fruta, 5);
        }
    }
}
