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
    public string Swap()
    {
        string output = "";
        foreach (char c in input)
        {
            char cypher;
            int pos = Convert.ToInt32(c) - 65;
            if (pos >= 0)
            {
                if (PlugBoard[pos] != '-')
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


    [ContextMenu("Fix")]
    void Fix()
    {
        for(int i =0; i < 26; i++)
        {
            PlugBoard[i] = Convert.ToChar(i + 65);
        }

    }

}
