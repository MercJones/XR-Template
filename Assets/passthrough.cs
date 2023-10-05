using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Wave.OpenXR.Toolkit.CompositionLayer.Passthrough;
using Wave.OpenXR.CompositionLayer;
public class Passthrough : MonoBehaviour
{
    int ID;
    // Start is called before the first frame update
    void Start()
    {
       CompositionLayerPassthroughAPI.CreatePlanarPassthrough(LayerType.Underlay);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.realtimeSinceStartup > 10)
        {
            //CompositionLayerPassthroughAPI.DestroyPassthrough(ID);
        }
    }
}
