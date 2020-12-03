using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class acButtonScript : MonoBehaviour
{
    private codeBarScripts codeBar;
    private int cIndex;
    public bool arrangeColor;
    public bool inputCode;


    private void Start()
    {
        codeBar = GameObject.FindGameObjectWithTag("codeBar").GetComponentInChildren<codeBarScripts>();

        if (arrangeColor)
        {
            if (codeBar.buttonIndex < 5)
            {
                cIndex = 1;
            }
            else if (codeBar.buttonIndex == 5)
            {
                cIndex = -1;
            }
        }
        if (inputCode)
        {
            if (codeBar.buttonIndex < 9)
            {
                cIndex = 1;
            }
            else if (codeBar.buttonIndex == 9)
            {
                cIndex = -1;
            }
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


    public void button1()
    {
        codeBar.buttons[codeBar.buttonIndex].GetComponent<cbButtonScripts>().SprIndex = 1;
        buttonIndexer();
        codeBar.code[codeBar.buttonIndex - cIndex] = "1";
    }
    public void button2()
    {
        codeBar.buttons[codeBar.buttonIndex].GetComponent<cbButtonScripts>().SprIndex = 2;
        buttonIndexer();
        codeBar.code[codeBar.buttonIndex - cIndex] = "2";
    }
    public void button3()
    {
        codeBar.buttons[codeBar.buttonIndex].GetComponent<cbButtonScripts>().SprIndex = 3;
        buttonIndexer();
        codeBar.code[codeBar.buttonIndex - cIndex] = "3";
    }
    public void button4()
    {
        codeBar.buttons[codeBar.buttonIndex].GetComponent<cbButtonScripts>().SprIndex = 4;
        buttonIndexer();
        codeBar.code[codeBar.buttonIndex - cIndex] = "4";
    }
    public void button5()
    {
        codeBar.buttons[codeBar.buttonIndex].GetComponent<cbButtonScripts>().SprIndex = 5;
        buttonIndexer();
        codeBar.code[codeBar.buttonIndex - cIndex] = "5";
    }
    public void button6()
    {
        codeBar.buttons[codeBar.buttonIndex].GetComponent<cbButtonScripts>().SprIndex = 6;
        buttonIndexer();
        codeBar.code[codeBar.buttonIndex - cIndex] = "6";
    }
    public void button7()
    {
        codeBar.buttons[codeBar.buttonIndex].GetComponent<cbButtonScripts>().SprIndex = 7;
        buttonIndexer();
        codeBar.code[codeBar.buttonIndex - cIndex] = "7";
    }
    public void button8()
    {
        codeBar.buttons[codeBar.buttonIndex].GetComponent<cbButtonScripts>().SprIndex = 8;
        buttonIndexer();
        codeBar.code[codeBar.buttonIndex - cIndex] = "8";
    }
    public void button9()
    {
        codeBar.buttons[codeBar.buttonIndex].GetComponent<cbButtonScripts>().SprIndex = 9;
        buttonIndexer();
        codeBar.code[codeBar.buttonIndex - cIndex] = "9";
    }
    public void button0()
    {
        codeBar.buttons[codeBar.buttonIndex].GetComponent<cbButtonScripts>().SprIndex = 10;
        buttonIndexer();
        codeBar.code[codeBar.buttonIndex - cIndex] = "0";
    }


    private void buttonIndexer()
    {
        if (arrangeColor)
        {
            if (codeBar.buttonIndex <= 5)
            {
                codeBar.buttonIndex++;
            }
        }
        if (inputCode)
        {
            if (codeBar.buttonIndex <= 9)
            {
                codeBar.buttonIndex++;
            }
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
    public void zeroIndexIC()
    {
        zeroIndex();
        codeBar.buttons[6].GetComponent<cbButtonScripts>().SprIndex = 0;
        codeBar.buttons[7].GetComponent<cbButtonScripts>().SprIndex = 0;
        codeBar.buttons[8].GetComponent<cbButtonScripts>().SprIndex = 0;
        codeBar.buttons[9].GetComponent<cbButtonScripts>().SprIndex = 0;
        codeBar.code[6] = "";
        codeBar.code[7] = "";
        codeBar.code[8] = "";
        codeBar.code[9] = "";
    }
}
