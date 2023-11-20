using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteamVisuals : MonoBehaviour
{
    public SteamValve valve;
    public GameObject visual;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (valve.steam > valve.steamThreshhold)
        {
            visual.SetActive(true);
        }
        else
        {
            {  visual.SetActive(false); }
        }
    }
}
