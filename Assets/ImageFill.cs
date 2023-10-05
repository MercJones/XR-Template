using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Content.Interaction;

public class ImageFill : MonoBehaviour
{
    public Image mask;
    public XRKnob wheel;

    public void SetFill()
    {
        mask.fillAmount = wheel.value;
    }
}
