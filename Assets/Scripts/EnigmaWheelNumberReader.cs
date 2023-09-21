using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnigmaWheelNumberReader : MonoBehaviour
{
    public GameObject cypherWheel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( cypherWheel != null && cypherWheel.GetComponent<EnigmaWheelCypher>() != null) 
        {
            this.GetComponent<TextMeshPro>().text = cypherWheel.GetComponent<EnigmaWheelCypher>().offset.ToString();
        }
        else
        {
            this.GetComponent<TextMeshPro>().text = "X";
        }

    }
}
