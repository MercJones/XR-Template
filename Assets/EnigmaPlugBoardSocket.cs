using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Filtering;

public class EnigmaPlugBoardSocket : MonoBehaviour
{
    public char plugChar;
    public int overlaps;
    XRSocketInteractor socket;
    // Start is called before the first frame update
    void Start()
    {
        socket = GetComponent<XRSocketInteractor>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InsertPlug()
    {
        IXRSelectInteractable ixr = socket.GetOldestInteractableSelected();
        //Collider[] hits = Physics.OverlapBox(this.transform.position, new Vector3(.029f, .239f, .139f));
        //foreach(Collider c in hits)
        {
            //if(ixr.gameObject.GetComponent<EnigmaPlugWire>())
            {
                ixr.transform.gameObject.GetComponent<EnigmaPlugWire>().ConnectPlug(this.gameObject);
            }
        }
    }

    public void RemovePlug()
    {
        IXRSelectInteractable ixr = socket.GetOldestInteractableSelected();
        EnigmaPlugBoard plugboard = FindAnyObjectByType<EnigmaPlugBoard>();
        for (int i = 0; i < 26; i++)
        { 
            if (plugboard.PlugBoard[i] == ixr.transform.gameObject.GetComponent<EnigmaPlugWire>().letter)
            {
                plugboard.PlugBoard[i] = '*';
            }
        }
        
    }


}
