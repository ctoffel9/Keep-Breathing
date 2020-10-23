using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lockDoor : MonoBehaviour

{
    private playerController PC;
    private bool lockedOff = false;
    public void lockingOff()
    {
        if (!lockedOff)
        {
            if (PC.key >= 1)
            {
                lockedOff = true;
                PC.key = PC.key - 1;
                Destroy(gameObject);
                Debug.Log("Berhasil");
                Debug.Log(PC.key);
            }
            
        }
       
    }

    private void Update()
    {
        PC = GameObject.FindWithTag("PlayerControl").GetComponent<playerController>();
    }
}
