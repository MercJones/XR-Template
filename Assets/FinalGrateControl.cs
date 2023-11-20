using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalGrateControl : MonoBehaviour
{
    public SteamValve heater;
    public bool thaw;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (heater != null && heater.steam > 35)
        {
            thaw = true;
        }
        else
        {
            thaw = false;
        }

    }

    public void openGrate()
    {
        if (thaw && this.transform.position.y > 1)
        {
            this.transform.position -= new Vector3(0f, Time.deltaTime / 3f, 0f);
        }
    }
}
