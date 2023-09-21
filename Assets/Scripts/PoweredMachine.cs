using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PoweredMachine : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject powerSource;
    public UnityEvent powerEvent;
    public UnityEvent offEvent;
    public bool powered = false;


    void Start()
    {
        if (powerEvent == null)
            powerEvent = new UnityEvent();

        powerEvent.AddListener(powerGo);
    }
    private void Update()
    {
        
    }

    public void powerGo()
    {
        {
            Debug.Log("Power");
            powerEvent.Invoke();
            return;
        }
    }

    public void powerOff()
    {
        {
            Debug.Log("off");
            offEvent.Invoke();
            return;
        }
    }
}
