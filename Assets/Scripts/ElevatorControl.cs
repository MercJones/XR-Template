using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorControl : MonoBehaviour
{
    public bool firstFloor = true;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        {
            this.gameObject.GetComponent<Animator>().Play("GoDown");
        }
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    [ContextMenu("Button")]
    public void MoveInAnElevator()
    {
        if (firstFloor) 
        {
            this.gameObject.GetComponent<Animator>().Play("GoUp");
            Debug.Log("Go Up");
            Player.transform.parent = this.gameObject.transform;
        }
        else 
        {
            this.gameObject.GetComponent<Animator>().Play("GoDown");
            Debug.Log("GoDown");
                
        }
    }
}
