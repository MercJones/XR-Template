using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class ResetCables : MonoBehaviour
{
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
       CreateCables();
    }
    //Instantiate cables
    public void DeleteCables()
    {
        
        GameObject[] cables = GameObject.FindGameObjectsWithTag("Cable");
        

        foreach (GameObject cable in cables)
        {
            cable.transform.position = new Vector3 (0, 0, 0); 
        }
        


    }
    //Delete all cables and reinstantiate them
    public void CreateCables()
    {
        GameObject[] spawns = GameObject.FindGameObjectsWithTag("Spawn");
        foreach (GameObject spawner in spawns) 
        { 
            Instantiate(prefab, spawner.transform); 
        }
        
    }
    [ContextMenu("Reset")]
    public void Reset()
    {
        DeleteCables();
        //CreateCables();
        GameObject[] cables = GameObject.FindGameObjectsWithTag("Cable");
        GameObject[] spawns = GameObject.FindGameObjectsWithTag("Spawn");
        //for(int i = 0; i < spawns.Length; i++) 
        {
            //cables[i].transform = spawns[i].transform;
        }
        EnigmaPlugBoard board = FindFirstObjectByType<EnigmaPlugBoard>();
        board.Fix();
    }
}
