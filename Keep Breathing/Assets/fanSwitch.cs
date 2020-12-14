using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fanSwitch : MonoBehaviour
{
    public Image image;
    public Sprite[] sprite;
    public int index = 0;
    private levelManager LM;

    private void Start()
    {
        LM = GameObject.FindWithTag("levelManager").GetComponent<levelManager>();
    }

    public void switching()
    {
        image.sprite = sprite[1];
        LM.switchOn = true;
    }
}
