using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using TMPro;
//using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class EnigmaInput : MonoBehaviour
{
    public string input;
    public GameObject CypherWheel1;
    public GameObject CypherWheel2;
    public GameObject CypherWheel3;
    public EnigmaPlugBoard plugBoard;


    // Start is called before the first frame update
    void Start()
    {
        plugBoard = GetComponent<EnigmaPlugBoard>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    [ContextMenu("Run Input")]
    public void Encode()
    {
        string codeString = "\n";
        string code = input;
        int offset = CypherWheel1.GetComponent<EnigmaWheelCypher>().offset;
        int offset2 = CypherWheel2.GetComponent<EnigmaWheelCypher>().offset;
        int offset3 = CypherWheel3.GetComponent<EnigmaWheelCypher>().offset;
        foreach (char c in code)
        {

            //translate character into numerical index
            int index = (Convert.ToInt32(c) - 65);
            //run through plug board
            index = plugBoard.PlugCypher(index);
            index += offset;
            if (index > 25)
            {
                index -= 26;
            }
            Debug.Log(c + " Converts to " + index);
           

            //Take the resulting index and get the character at that index
            Debug.Log("Index routes to " + CypherWheel1.GetComponent<EnigmaWheelCypher>().encryptionKey[index]);
            int conversion = Convert.ToInt32(CypherWheel1.GetComponent<EnigmaWheelCypher>().encryptionKey[index]);
            Debug.Log("Value at index converts to " + (conversion - 65));
            index = conversion - 65 + offset2;
            if (index > 25)
            {
                index -= 26;
            }
            Debug.Log("Index routes to " + CypherWheel2.GetComponent<EnigmaWheelCypher>().encryptionKey[index]);
            conversion = Convert.ToInt32(CypherWheel2.GetComponent<EnigmaWheelCypher>().encryptionKey[index]);
            Debug.Log("Value at index converts to " + (conversion - 65));
            index = conversion - 65 + offset3;
            if (index > 25)
            {
                index -= 26;
            }
            Debug.Log("Index routes to " + CypherWheel3.GetComponent<EnigmaWheelCypher>().encryptionKey[index]);
            conversion = Convert.ToInt32(CypherWheel3.GetComponent<EnigmaWheelCypher>().encryptionKey[index]);
            Debug.Log("Value at index converts to " + (conversion - 65));
          
          
            //reflect to the opposing letter
            conversion += (13);
            if (conversion > 90)
            {
                conversion -= 26;
            }

           

            Debug.Log("Index reflects to " + conversion);
            char cypher = (char)(conversion);
            index = Array.IndexOf(CypherWheel3.GetComponent<EnigmaWheelCypher>().encryptionKey, cypher);
            Debug.Log("Index converts to " + (char)(index + 65));
            int tempCypher = (index - offset3);
            if (tempCypher < 0)
            {
                tempCypher += 26;
            }
            Debug.Log(tempCypher);
            cypher = (char)(tempCypher+65);
            Debug.Log("Cypher character is " + cypher);


            index = Array.IndexOf(CypherWheel2.GetComponent<EnigmaWheelCypher>().encryptionKey, cypher);
            Debug.Log("Index converts to " + (char)(index + 65));
            tempCypher = (index - offset2);
            if (tempCypher < 0)
            {
                tempCypher += 26;
            }
            Debug.Log(tempCypher);

            cypher = (char)(tempCypher + 65);
            Debug.Log("Cypher character is " + cypher);

            index = Array.IndexOf(CypherWheel1.GetComponent<EnigmaWheelCypher>().encryptionKey, cypher);
            Debug.Log("Index converts to " + (char)(index + 65));
            tempCypher = (index - offset);
            if (tempCypher < 0)
            {
                tempCypher += 26;
            }

            //run through plug board
            tempCypher = plugBoard.PlugCypher(tempCypher);
            Debug.Log("Plug returns " + tempCypher);
            cypher = (char)(tempCypher + 65);
            Debug.Log("Cypher character is " + cypher);
            char outCypher = cypher;

            codeString += outCypher;
            offset++;
            if (offset > 25)
            {
                offset = 0;
                offset2++;
                if (offset2 > 25)
                {
                    offset2 = 0;
                    offset3++;
                    if (offset3 > 25)
                    {
                        offset3 = 0;
                    }
                }
            }

        }
            this.gameObject.GetComponent<TextMeshPro>().text = (code + "\r\n" + codeString);
    }
}