using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR.Haptics;
using UnityEngine.EventSystems;
using System;

public class DoorTask : MonoBehaviour
{
    public static DoorTask current;

    private void Awake()
    {
        current = this;
    }
    public event Action<string> onTaskComplete;
    public void completeTrigger(string id)
    {
        if (onTaskComplete != null)
        {
            onTaskComplete(id);
        }
    }

}
