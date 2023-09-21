using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Content.Interaction;
using UnityEngine.XR.Interaction.Toolkit;

public class SteamValve : MonoBehaviour
{
    public float steam;
    public bool open = false;
    public SteamValve leadingValve;
    public XRKnob handValve;
    public float steamThreshhold = .25f;
    public string targetID = "none";
    public SteamPuzzleManager puzzleManager;
    public AudioClip openSFX;
    public AudioClip closeSFX; 
   
    // Start is called before the first frame update
    [ContextMenu("Turn Valve")]
    public void TurnValve()
    {
        Debug.Log("Turn");
        if (open)
        { 
            open = false;
            this.transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = Color.white;
            puzzleManager.UpdateSteam();
            this.gameObject.GetComponent<AudioSource>().PlayOneShot(openSFX, 1);
            //this.gameObject.GetComponent<AudioSource>().Play();
        }
        else
        { 
            open = true;
            this.transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = Color.green;
            puzzleManager.UpdateSteam();
        }
    }

    public void Turn()
    {
        Debug.Log("Turn" + handValve.value);
        if (handValve.value < .1f)
        {
            open = true;
            Debug.Log("Open" + handValve.value);
            //this.transform.GetChild(0).GetComponent<Renderer>().material.color = Color.green;
            puzzleManager.UpdateSteam();
            this.gameObject.GetComponent<AudioSource>().PlayOneShot(openSFX, 1);

        }
       
        if (handValve.value > .9f)
          {
            Debug.Log("Close" + handValve.value);
            open = false;
           //this.transform.GetChild(0).GetComponent<Renderer>().material.color = Color.white;
            puzzleManager.UpdateSteam();
            this.gameObject.GetComponent<AudioSource>().PlayOneShot(closeSFX, 1);
        }
        
    }

    public void PowerEvent()
    {
        Debug.Log("Checking Power");
        if (steam >= steamThreshhold)
        {
            DoorTask.current.completeTrigger(targetID);
            Debug.Log("Sending power to " + targetID);
        }
    }
}
