using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class EngimaSocketInteract : MonoBehaviour
{
    public int slot = 1;
    public GameObject machine;
    public GameObject socketObj;
    public GameObject readOut;
   public void SetObjectCypher()
    {
        IXRSelectInteractable socketInteract;
      
        socketInteract = gameObject.GetComponent<XRSocketInteractor>().GetOldestInteractableSelected();
        Debug.Log(socketInteract);
        socketObj = socketInteract.transform.gameObject;
        if (slot == 1)
        {
            machine.gameObject.GetComponent<EnigmaInput>().CypherWheel1 = socketObj;
        }

        if (slot == 2)
        {
            machine.gameObject.GetComponent<EnigmaInput>().CypherWheel2 = socketObj;
        }

        if (slot == 3)
        {
            machine.gameObject.GetComponent<EnigmaInput>().CypherWheel3 = socketObj;
        }
    }

    public void updateKnobAssociation(GameObject Knob)
    {
        Knob.GetComponent<NumberSetter>().cypherWheel = socketObj;
        readOut.GetComponent<EnigmaWheelNumberReader>().cypherWheel = socketObj;
    }
}
