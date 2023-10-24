using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;

public class EnigmaPlugBoard : MonoBehaviour
{
    public string input;
    
    public char firstPlug;
    public char secondPlug;

    public char[] PlugBoard = new char[26];

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    [ContextMenu("Run Input")]
    public void RunPlugSwap(string input)
    {

    }
    [ContextMenu("Insert Plug")]
    void ManualRead()
    {
        InsertPlug(firstPlug, secondPlug);

    }

    public void InsertPlug(char plug1, char plug2)
    {
        PlugBoard[Convert.ToInt32(plug1 - 65)] = plug2;
        PlugBoard[Convert.ToInt32(plug2 - 65)] = plug1;
    }
    [ContextMenu("Swap")]
    public string Swap(string inString)
    {
        string output = "";
        foreach (char c in inString)
        {
            char cypher;
            int pos = Convert.ToInt32(c) - 65;
            if (pos >= 0)
            {
                if (PlugBoard[pos] != '*')
                {
                    cypher = PlugBoard[pos];
                    output += cypher;
                }
                else
                {
                    output += c;
                }
            }

        }
        UnityEngine.Debug.Log(output);
        input = output;
        return output;
      
    }

    public int PlugCypher(int input)
    {
      
        UnityEngine.Debug.Log("Plugboard recieves" + input);
        int cypher;
        if (PlugBoard[input] != '*' )
        {
            UnityEngine.Debug.Log("Value at plugboard is" + PlugBoard[input]);
            cypher = Convert.ToInt32(PlugBoard[input]-65);
            return cypher;
        }
        UnityEngine.Debug.Log("No return from plug" + input);
        return (input);
    }


    [ContextMenu("Fix")]
    public void Fix()
    {
        //PlugBoard = new char[26];
        
        for(int i =0; i < 26; i++)
        {
            PlugBoard[i] = '*';//Convert.ToChar(i + 65);
        }

    }

    

}
