using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MessageSocket : MonoBehaviour
{
    public GameObject Machine;
   void GetMessage(GameObject message)
    {
        Machine.gameObject.GetComponent<EnigmaInput>().input = message.transform.GetChild(0).GetComponent<TextMeshPro>().text;
    }

    private void OnTriggerEnter(Collider other)
    {
        GetMessage(other.gameObject);
    }
}
