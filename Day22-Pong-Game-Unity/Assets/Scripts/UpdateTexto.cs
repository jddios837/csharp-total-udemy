using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateTexto : MonoBehaviour
{
    public Text miText;

    private int numText = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            numText++;
            miText.text = numText.ToString();
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            miText.text = "Move Right";
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            miText.text = "Move Left";
        }
    }
}
