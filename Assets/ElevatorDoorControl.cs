using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ElevatorDoorControl : MonoBehaviour
{
    public string localID = "Door 2";
    public bool invoked = false;
    // Start is called before the first frame update
    void Start()
    {
        DoorTask.current.onTaskComplete += OnComplete;
    }

    private void OnComplete(string id)
    {
        Debug.Log(this.gameObject + " Detecting event for " + id);
        if (id == localID && invoked == false)
        {
            this.gameObject.GetComponent<Animator>().enabled = true;
            Debug.Log("Opening");
            invoked = true;
            this.GetComponent<AudioSource>().Play();
        }
    }
}
