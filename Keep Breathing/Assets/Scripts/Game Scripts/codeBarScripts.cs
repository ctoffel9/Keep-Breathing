using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class codeBarScripts : MonoBehaviour
{
    public GameObject[] buttons;
    public string[] code = new string[4];
    public int buttonIndex;
    private string AccessCode;
    public string DesireCode;
    public bool controlPanelON;

    private void Start()
    {
        buttonIndex = 0;
        
    }

    private void Update()
    {
        {
            AccessCode = code[0] + code[1] + code[2] + code[3] + code[4] + code[5];
        }


        if (AccessCode == DesireCode)
        {
            controlPanelON = true;
        }
    }

}
