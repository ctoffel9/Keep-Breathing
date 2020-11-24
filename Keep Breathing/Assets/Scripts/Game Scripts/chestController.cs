using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chestController : MonoBehaviour
{
    public bool isOpen;
    public Animator anim;
    private inventorySystem inventory;
    public GameObject itemButton;
    private playerController player;
    public GameObject IC;
    bool inventOn;
    public void openChest()
    {
        if (!isOpen)
        {
            if (inventOn)
            {
                if (gameObject.tag == "key")
                {
                    player.key = player.key + 1;
                    Debug.Log("keying berhasil");
                }
                isOpen = true;
                Debug.Log("Chest is now open...");
                for (int i = 0; i < inventory.slots.Length; i++)
                {
                    if (inventory.isFull[i] == false)
                    {
                        inventory.isFull[i] = true;
                        Instantiate(itemButton, inventory.slots[i].transform);
                        break;

                    }

                }
            }
            else
            {
                isOpen = false;
                Debug.Log(" There are no Inventory");
            }

        }
    }

    private void Update()
    {
        player = GameObject.FindWithTag("PlayerControl").GetComponent<playerController>();
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<inventorySystem>();
        if (isOpen == true)
        {
            anim.SetBool("isOpen", true);
            IC.SetActive(false);
        }
        if (inventory != null)
        {
            inventOn = true;
        }
        else
        {
            inventOn = false;
        }


    }

}
