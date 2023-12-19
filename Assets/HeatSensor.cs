using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HeatSensor : MonoBehaviour
{
    private string coldF = "30 F";
    private string coldC = "-1 C";
    private string hotF = "50  F";
    private string hotC = "10 C";
    public bool isF = true;
    public SteamValve heater;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isF == true)
        {
            if (heater.steam > 10)
            {
                this.gameObject.GetComponent<TextMeshPro>().text = hotF;
            }
            else
            {
                this.gameObject.GetComponent<TextMeshPro>().text = coldF;
            }

        }
        else
        {
            if (heater.steam > 10)
            {
                this.gameObject.GetComponent<TextMeshPro>().text = hotC;
            }
            else
            {
                this.gameObject.GetComponent<TextMeshPro>().text  = coldC;
            }
        }
    }

    public void SetF(bool f)
    {
        isF = f;
    }
}
   
