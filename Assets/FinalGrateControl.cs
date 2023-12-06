using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalGrateControl : MonoBehaviour
{
    public SteamValve heater;
    public bool thaw;
    public GameObject motorChild;
    private bool audioPlay = false;
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
        if (this.transform.position.y < 1 && audioPlay == false )
        {
            {
                this.GetComponent<AudioSource>().Play();
                audioPlay = true;
            }
        }
        motorChild.GetComponent<AudioSource>().volume -= Time.deltaTime;
    }

    public void openGrate()
    {
        if (thaw && this.transform.position.y > 1)
        {
            this.transform.position -= new Vector3(0f, Time.deltaTime / 3f, 0f);
            motorChild.GetComponent<AudioSource>().volume = .5f;
            motorChild.GetComponent<AudioSource>().pitch = 0.3f;
        }

        else if (thaw == false)
        {
            motorChild.GetComponent<AudioSource>().volume = .7f;
            motorChild.GetComponent<AudioSource>().pitch = .6f;
        }

       // motorChild.GetComponent<AudioSource>().volume = 0f;
    }
}
