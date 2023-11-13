using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Content.Interaction;

public class BatteryFill : MonoBehaviour
{
    public Image mask;
    public BatteryCharge wheel;

    public void Update()
    {
        mask.fillAmount = (wheel.charge / 15f);
        Debug.Log("Fill amount " + mask.fillAmount);
    }
}
