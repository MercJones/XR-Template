using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterCooler : MonoBehaviour
{
    public SteamPuzzleManager leadValve;

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
    public void steamUp()
    {
        Debug.Log("Pressurizing");
        leadValve.pressure = 200;
    }

    public void steamDown()
    {
        leadValve.pressure = 100;
    }
}
