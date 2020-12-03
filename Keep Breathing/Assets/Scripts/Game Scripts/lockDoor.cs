using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lockDoor : MonoBehaviour
    
{
    public GameObject popUP;

    private void Start()
    {
     popUP.SetActive(false);   
    }
    public void showPopUp()
    {
        popUP.SetActive(true);
    }
}
