using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Helloworldtxt : MonoBehaviour
{
    // Start is called before the first frame update
    public Text newText;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            newText.text = "Hello, my name is Nicholas Johnson!";
        }
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}
