using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class acButtonScript : MonoBehaviour
{
    private codeBarScripts codeBar;
    private int cIndex;


    private void Start()
    {
        codeBar = GameObject.FindGameObjectWithTag("codeBar").GetComponentInChildren<codeBarScripts>();
        if (codeBar.buttonIndex < 5)
        {
            cIndex = 1;
        } else if (codeBar.buttonIndex == 5)
        {
            cIndex = -1;
        }

        

    }

    private void Update()
    {
    }
    public void RbuttonClick()
    {
        codeBar.buttons[codeBar.buttonIndex].GetComponent<cbButtonScripts>().SprIndex = 1;
        buttonIndexer();
        codeBar.code[codeBar.buttonIndex - cIndex] = "R";
    }
    public void YbuttonClick()
    {
        codeBar.buttons[codeBar.buttonIndex].GetComponent<cbButtonScripts>().SprIndex = 2;
        buttonIndexer();
        codeBar.code[codeBar.buttonIndex - cIndex] = "Y";
    }
    public void GbuttonClick()
    {
        codeBar.buttons[codeBar.buttonIndex].GetComponent<cbButtonScripts>().SprIndex = 3;
        buttonIndexer();
        codeBar.code[codeBar.buttonIndex - cIndex] = "G";
    }

    private void buttonIndexer()
    {
        if (codeBar.buttonIndex <= 5)
        {
            codeBar.buttonIndex++;
        }
    }

    public void zeroIndex()
    {
        codeBar.buttons[0].GetComponent<cbButtonScripts>().SprIndex = 0;
        codeBar.buttons[1].GetComponent<cbButtonScripts>().SprIndex = 0;
        codeBar.buttons[2].GetComponent<cbButtonScripts>().SprIndex = 0;
        codeBar.buttons[3].GetComponent<cbButtonScripts>().SprIndex = 0;
        codeBar.buttons[4].GetComponent<cbButtonScripts>().SprIndex = 0;
        codeBar.buttons[5].GetComponent<cbButtonScripts>().SprIndex = 0;
        codeBar.buttonIndex = 0;
        codeBar.code[0] = "";
        codeBar.code[1] = "";
        codeBar.code[2] = "";
        codeBar.code[3] = "";
        codeBar.code[4] = "";
        codeBar.code[5] = "";
    }
}
