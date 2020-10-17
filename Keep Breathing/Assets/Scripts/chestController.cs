using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chestController : MonoBehaviour
{
    public bool isOpen;
    public Animator anim;   
    public void openChest()
    {
        if (!isOpen)
        {
            isOpen = true;
            Debug.Log("Chest is now open...");
        }
    }

    private void Update()
    {
       if (isOpen == true)
        {
            anim.SetBool("isOpen", true);
        }
    }

}
