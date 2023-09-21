using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class PLC_Reciever : MonoBehaviour
{
    public GameObject correctPlug;
    public bool isCorrect = false;
    public GameObject indicator;
    public List<GameObject> plugs = new List<GameObject>();
    public Material wrong;
    public Material half;
    public Material correct;
    public Material blank;
    public int overlaps;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  public bool CheckPlug()
    {
        if (overlaps > 0)
        {

            if (correctPlug != null)
            {

                if (this.gameObject.GetComponent<Collider>().bounds.Intersects(correctPlug.GetComponent<Collider>().bounds))

                {
                    Debug.Log(" Correct");
                    indicator.gameObject.GetComponent<Renderer>().material = correct;
                    return true;
                }

                else
                {
                    Debug.Log("Incorrect");
                    indicator.gameObject.GetComponent<Renderer>().material = wrong;
                    foreach (GameObject go in plugs)
                    {
                        if (this.gameObject.GetComponent<Collider>().bounds.Intersects(go.GetComponent<Collider>().bounds))
                        {
                            indicator.gameObject.GetComponent<Renderer>().material = half;
                            break;
                        }
                    }
                    return false;
                }
            }
            if (correctPlug == null)
            {
                indicator.gameObject.GetComponent<Renderer>().material = wrong;
                foreach (GameObject go in plugs)
                {
                    if (this.gameObject.GetComponent<Collider>().bounds.Intersects(go.GetComponent<Collider>().bounds))
                    {
                        indicator.gameObject.GetComponent<Renderer>().material = half;
                        break;
                    }
                }
                return false;
                
            }
            else
            {
                return true;
            }
        }
        else
        {
            indicator.gameObject.GetComponent<Renderer>().material = blank;
           
            return true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        overlaps++;
        Debug.Log(overlaps);
    }

    private void OnTriggerExit(Collider other)
    {
        overlaps--;
        Debug.Log(overlaps);
    }



}
