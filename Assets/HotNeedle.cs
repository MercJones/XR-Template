using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HotNeedle : MonoBehaviour
{
    public WaterCooler leadValve;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float pressureAngle = Mathf.Clamp(leadValve.localPressure - 100, -40f, 220f);
        this.gameObject.transform.localEulerAngles = new Vector3(0, 0, pressureAngle);
    }
}
