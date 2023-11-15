using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.XR.Content.Interaction;
using UnityEngine.XR.Interaction.Toolkit;

public class NumberSetter : MonoBehaviour
{
   public int Value = 0;
   public GameObject knob;
   public GameObject cypherWheel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (knob != null)
        {
            Value = (int)(knob.transform.rotation.y / .04f);
            if (cypherWheel != null) { cypherWheel.GetComponent<EnigmaWheelCypher>().offset = Value; }
        }
       
    }

    public void numUp()
    {
        Value += 1;
        if(Value > 25)
        {
            Value = 0;
        }
        if (cypherWheel != null) { cypherWheel.GetComponent<EnigmaWheelCypher>().offset = Value; }
    }
    
    public void numDown()
    {
        Value -= 1;
        if (Value < 0)
        {
            Value = 25;
        }
        if (cypherWheel != null) { cypherWheel.GetComponent<EnigmaWheelCypher>().offset = Value; }
    }
}
