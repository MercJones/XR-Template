using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteamPuzzleManager : MonoBehaviour
{
    public GameObject[] valves;
    public float pressure = 100.0f;
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject ve in valves)
        {
            ve.GetComponent<SteamValve>().puzzleManager = this;
        }
    }

    // Update is called once per frame
    public void UpdateSteam()
    {
        List<GameObject> openValves = new List<GameObject>();
        foreach(GameObject ve in valves) 
        {
            if (ve.GetComponent<SteamValve>().open && (ve.GetComponent<SteamValve>().leadingValve.open == true))
            {
                openValves.Add(ve);
                Debug.Log("Adding to open valves" + ve);
            }
            else
            {
                ve.GetComponent<SteamValve>().steam = 0;
            }
            foreach(GameObject v in openValves) 
            {
                v.GetComponent<SteamValve>().steam = (pressure / (openValves.Count));
                v.GetComponent<SteamValve>().PowerEvent();
                Debug.Log("Checking power on " + v);
            }

        }
    }
}
