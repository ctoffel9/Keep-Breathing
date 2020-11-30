using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    public Image image, image2;
    public Color color, color2, colortemp;

    private void Awake()
    {
        color = image.color;
        color2 = image2.color;
    }

    public void OnSetActive()
    {
        colortemp = color;
        color = color2;
        color2 = colortemp;

        image.color = color;
        image2.color = color2;
    }

    public void OnSetDeactive()
    {
        image.color = color;
        image2.color = color2;

        colortemp = color;
        color = color2;
        color2 = colortemp;
    }
}
