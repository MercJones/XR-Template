using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generatorEvent : MonoBehaviour
{
    public GameObject target;
   
    
        void Start()
        {
            DoorTask.current.onTaskComplete += OnComplete;
        }
    
    private void OnComplete(string id)
    {
        if(id == "Power")
        {
            GetPower();
        }
    }
   public void GetPower()
    {
        Debug.Log("Move Screen");
        //This was what we were using when it was just a code to turn on.
        //target.SetActive(true);

    }
}
