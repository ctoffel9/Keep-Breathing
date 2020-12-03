using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cbButtonScripts : MonoBehaviour
{
    public Sprite[] spr;
    public int SprIndex;
    public Sprite defaultSpr;
    public bool arrangeColor;
    public bool inputCode;


    private void Start()
    {
        SprIndex = 0;
    }

    private void Update()
    {
        //arrange color;
        if (arrangeColor)
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

        }//Input code
        if (inputCode)
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
            if (SprIndex == 4)
            {
                gameObject.GetComponent<Image>().sprite = spr[3];
            }
            if (SprIndex == 5)
            {
                gameObject.GetComponent<Image>().sprite = spr[4];
            }
            if (SprIndex == 6)
            {
                gameObject.GetComponent<Image>().sprite = spr[5];
            }
            if (SprIndex == 7)
            {
                gameObject.GetComponent<Image>().sprite = spr[6];
            }
            if (SprIndex == 8)
            {
                gameObject.GetComponent<Image>().sprite = spr[7];
            }
            if (SprIndex == 9)
            {
                gameObject.GetComponent<Image>().sprite = spr[8];
            }
            if (SprIndex == 10)
            {
                gameObject.GetComponent<Image>().sprite = spr[9];
            }

        }


    }
}
