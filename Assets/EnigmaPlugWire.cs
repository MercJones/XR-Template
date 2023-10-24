using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.XR.Content.Interaction;
using UnityEngine.XR.Interaction.Toolkit;
public class EnigmaPlugWire : MonoBehaviour
{
    public EnigmaPlugWire otherEnd;
    public EnigmaPlugBoard board;
    public char letter;
    public bool inSlot;
    // Start is called before the first frame update
    void Start()
    {
        board = FindAnyObjectByType<EnigmaPlugBoard>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetLetterPlug(GameObject xrSock)
    {
       // letter = xrsock.transform.gameObject.GetComponent<EnigmaPlugBoardSocket>().plugChar;
        Collider[] hits = Physics.OverlapBox(this.transform.position, new Vector3(.015f, .01f, .01f));
        //foreach (Collider c in hits)
        {
            if (xrSock.gameObject.GetComponent<EnigmaPlugBoardSocket>())
            {
                letter = xrSock.GetComponent<EnigmaPlugBoardSocket>().plugChar;
            }
        }
    }

    public void ConnectPlug(GameObject xrsock)
    {
        SetLetterPlug(xrsock.gameObject);
        inSlot = true;
        if (otherEnd != null && otherEnd.inSlot == true)
        {
            int convertA = (int)letter;
            board.InsertPlug(letter, otherEnd.letter);
        }
    }

    public void removePlug()
    {
        letter = '*';
    }
}
