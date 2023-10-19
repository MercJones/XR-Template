using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLC_Controller : MonoBehaviour
{
    public GameObject[] plugs;
    //public List<GameObject> answers = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [ContextMenu("CheckCorrect")]
    public void CheckAllPlugs()
    {
        bool correct = true;
        foreach(GameObject go in plugs)
        { 
            if (go.GetComponent<PLC_Reciever>().CheckPlug() == false)
            {
                correct = false;
                //break;
            }
        }

        if (correct)
        {
            Debug.Log("The Puzzle is correct");
            DoorTask.current.completeTrigger("Door 1");
            this.GetComponent<AudioSource>().Play();
        }
    }
}
