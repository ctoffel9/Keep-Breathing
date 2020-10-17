using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dangerZone : MonoBehaviour
{
    public lifeSystem lS;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            lS.dangerZone = true;
            Debug.Log("Entering Danger Zone");
        } 
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            lS.dangerZone = false;
            Debug.Log("Leaving Danger Zone");
        }
    }
}
