using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class BatteryCharge : MonoBehaviour
{
    public float charge;
    public SteamValve source;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(source.steam > 34 && charge < 15f)
        {
            charge += Time.deltaTime / 2;
            
        }
        Mathf.Clamp(charge, 0, 15);
        if (charge > 5)
        {
            Debug.Log("Open Gate");
            target.GetComponent<FinalGrateControl>().openGrate();
            charge -= Time.deltaTime / 4;
        }
    }
}
