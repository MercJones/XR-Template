using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TabletPages : MonoBehaviour
{
    public GameObject screen;
    public List<Texture> pages;
    public int currentPage = 0;
    public InputActionReference downAction = null;
    public InputActionReference downAction2 = null;
    public InputActionReference upAction = null;
    public InputActionReference upAction2 = null;
    public bool held = false;


    private void Awake()
    {
        downAction.action.performed += _ => pageDown();
        upAction.action.performed += _ => pageUp();
        downAction2.action.performed += _ => pageDown();
        upAction2.action.performed += _ => pageUp();
    }
    public void pickUp()
    {
        held = true;
    }
    public void Drop()
    {
        held = false;
    }

    
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pageUp()
    {
        if(held)
        {
            currentPage += 1;
            if (currentPage >= pages.Count) { currentPage = 0; }
            Texture newPage = pages[currentPage];
            screen.GetComponent<Renderer>().material.mainTexture = newPage;
        }
    }
 
    public void pageDown()
    {
        if (held)
        {
            currentPage -= 1;
            if (currentPage < 0) { currentPage = pages.Count - 1; }
            Texture newPage = pages[currentPage];
            screen.GetComponent<Renderer>().material.mainTexture = newPage;
        }
    }
}
