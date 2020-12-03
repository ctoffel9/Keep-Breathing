using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cbButtonScripts : MonoBehaviour
{
    public Sprite[] spr;
    public int SprIndex;
    public Sprite defaultSpr;


    private void Start()
    {
        SprIndex = 0;
    }

    private void Update()
    {
        if (SprIndex == 0)
        {
            gameObject.GetComponent<Image>().sprite = defaultSpr;
        }
        if (SprIndex == 1)
        {
            gameObject.GetComponent<Image>().sprite = spr[0];
        }
        if (SprIndex == 2)
        {
            gameObject.GetComponent<Image>().sprite = spr[1];
        }
        if (SprIndex == 3)
        {
            gameObject.GetComponent<Image>().sprite = spr[2];
        }

    }
}
