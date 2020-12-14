using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dangerZone : MonoBehaviour
{
    public lifeSystem lS;
    public bool yellow = false;
    public bool red = false;
    public bool black = false;
    private bool playerOnPoint;

    public GameObject yellowPanel;
    public GameObject redPanel;
    public GameObject blackPanel;


    /*private void Update()
    {
        if (yellow)
        {
            lS.maskDecrease = 0.1f;
            //red = false;
            //black = false;
        }
        if (red)
        {
            lS.maskDecrease = 0.5f;
            //yellow = false;
            //black = false;
        }
        if (black)
        {
            lS.maskDecrease = 1f;
            //yellow = false;
            //red = false;
        }
    }*/
    
    void maskDecrease()
    {
        if (yellow)
        {
            lS.maskDecrease = 0.1f;
            //red = false;
            //black = false;
        }
        if (red)
        {
            lS.maskDecrease = 0.5f;
            //yellow = false;
            //black = false;
        }
        if (black)
        {
            lS.maskDecrease = 1f;
            //yellow = false;
            //red = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerOnPoint = true;
            if (playerOnPoint)
            {
                maskDecrease();
            }

            if (yellow)
            {
                yellowPanel.SetActive(true);
            } else if (red)
            {
                redPanel.SetActive(true);
            } else if (black)
            {
                blackPanel.SetActive(true);
            }
            lS.dangerZone = true;
            Debug.Log("Entering Danger Zone");
        } 
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerOnPoint = false;
            if (yellow)
            {
                yellowPanel.SetActive(false);
            }
            else if (red)
            {
                redPanel.SetActive(false);
            }
            else if (black)
            {
                blackPanel.SetActive(false);
            }
            lS.dangerZone = false;
            Debug.Log("Leaving Danger Zone");
        }
    }
}
