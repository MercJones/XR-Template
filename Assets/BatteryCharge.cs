using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class BatteryCharge : MonoBehaviour
{
    public float charge;
    public bool leverOn = true;
    public SteamValve source;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(source.steam > 60 && charge < 15f)
        {
            charge += Time.deltaTime / 2;
            
        }
        
        if (leverOn && charge > 5)
        {
            Debug.Log("Open Gate");
            target.GetComponent<FinalGrateControl>().openGrate();
            charge -= Time.deltaTime;
        }

        if(charge < 0)
        {
            charge = 0;
        }
    }

    public void SetLever(bool state)
    {
        leverOn = state;
    }
}
