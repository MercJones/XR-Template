using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manualspawn : MonoBehaviour
{
    public GameObject smokeObj;
    public Transform smokespot;
    // Start is called before the first frame update
    void Start()
    {
        Smoke();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [ContextMenu("Smoke")]

    public void Smoke()
    {
        Instantiate(smokeObj, smokespot);  
    }
}
