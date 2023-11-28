using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Content.Interaction;

public class WaterCooler : MonoBehaviour
{
    public GameObject hotInlet;
    public GameObject coldInlet;
    public SteamPuzzleManager leadValve;
    public float localPressure;

    public void pressureUpdate()
    {
        float hot = hotInlet.gameObject.GetComponentInChildren<XRKnob>().value;
        float cold= coldInlet.gameObject.GetComponentInChildren<XRKnob>().value;
        localPressure = (hot * 600) - (cold * 250);
        
        if (localPressure < 300 && localPressure > 175 && hot + cold > 1.0)
        {
            steamUp();
        }
        else
        {
            steamDown();
        }

    
    }

    public void steamUp()
    {
        Debug.Log("Pressurizing");
        leadValve.pressure = 200;
    }

    public void steamDown()
    {
        Debug.Log("Failure");
        leadValve.pressure = 0;
    }
    /*
  

    void Start()
    {
        DoorTask.current.onTaskComplete += OnComplete;
    }

    private void OnComplete(string id)
    {
        if (id == "Water")
        {
            steamUp();
        }
    }
  

    public void steamDown()
    {
        leadValve.pressure = 100;
    }
    */
}
