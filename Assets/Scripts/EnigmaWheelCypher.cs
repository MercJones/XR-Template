using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class EnigmaWheelCypher : MonoBehaviour
{
    public int offset;
    private GameObject tempGO;
    public char[] encryptionKey;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    [ContextMenu("Fix")]
    public void Fix()
    {
        for(int i = 0; i< 26; i++) 
        {
            encryptionKey[i] = Convert.ToChar(i+65);
        }
    }

    [ContextMenu("Shuffle")]
    void Shuffle()
    {
        
        int p = encryptionKey.Length;
        for (int n = p - 1; n > 0; n--)
        {
            int r = UnityEngine.Random.Range(0, n);
            int t = encryptionKey[r];
            encryptionKey[r] = encryptionKey[n];
            encryptionKey[n] = Convert.ToChar(t);
        }
        
        
    }
    public char Cypher(char input)
    {
        int cypheredChar;
        cypheredChar = input + offset;
        char output = System.Convert.ToChar(cypheredChar);
        return output;
    }

}
