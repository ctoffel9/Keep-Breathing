using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitches : MonoBehaviour
{
    private levelManager LManager;
    public GameObject switchesA;
    public GameObject switchesB;
    public bool onA;
    public bool onB;

    private void Start()
    {
        LManager = GameObject.Find("level Manager").GetComponent<levelManager>();
    }

    private void Update()
    {
        if (onA)
        {
            LManager.Lights[0].SetActive(true);
            LManager.Lights[2].SetActive(true);
        }
        else
        {
            LManager.Lights[0].SetActive(false);
            LManager.Lights[2].SetActive(false);
        }
        if (onB)
        {
            LManager.Lights[1].SetActive(true);
        }
        else
        {
            LManager.Lights[1].SetActive(false);
        }
        if (onA & onB)
        {
            LManager.Lights[0].SetActive(false);
            LManager.Lights[1].SetActive(false);
            LManager.Lights[2].SetActive(false);
        }
    }

    public void switchOnA()
    {
            if (!onA)
            {
                switchesA.gameObject.GetComponent<RectTransform>().localScale = new Vector3(-2, -2, 0);
                onA = true;
            }
            else if (onA)
            {
                switchesA.gameObject.GetComponent<RectTransform>().localScale = new Vector3(-2, 2, 0);
                onA = false;
            }
        
        
    }
    public void switchOnB()
    {
            if (!onB)
            {
                switchesB.gameObject.GetComponent<RectTransform>().localScale = new Vector3(2, -2, 0);
                onB = true;
            }
            else if (onB)
            {
                switchesB.gameObject.GetComponent<RectTransform>().localScale = new Vector3(2, 2, 0);
                onB = false;
            }
       
    }

}
