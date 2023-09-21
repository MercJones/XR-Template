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
        Debug.Log("Power on");
        target.SetActive(true);

    }
}
