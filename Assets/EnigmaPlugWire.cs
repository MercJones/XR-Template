using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnigmaPlugWire : MonoBehaviour
{
    public EnigmaPlugWire otherEnd;
    public EnigmaPlugBoard board;
    public char letter;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetLetterPlug()
    {
        {
            RaycastHit[] hits = this.gameObject.GetComponent<Rigidbody>().SweepTestAll(new Vector3(0, 0, 0), 0f);
            foreach (var hit in hits)
            {
                if (hit.transform.gameObject.GetComponent<EnigmaPlugBoardSocket>())
                {
                    letter = hit.transform.gameObject.GetComponent<EnigmaPlugBoardSocket>().plugChar;
                    break;
                }
            }
        }
    }

    public void ConnectPlug()
    {
        int convertA = (int)letter;
        board.InsertPlug(letter, otherEnd.letter);
    }
}
