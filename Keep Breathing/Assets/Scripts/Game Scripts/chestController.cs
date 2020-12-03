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
    private lifeSystem LSystem;
    public GameObject IC;
    public GameObject DM;
    bool inventOn;

    private void Start()
    {
        DM.SetActive(false);
        this.gameObject.tag = itemButton.tag;
    }
    public void openChest()
    {
        if (!isOpen)
        {
            if (inventOn)
            {
                weightSystem();
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

                DM.SetActive(true);

            }
            else
            {
                isOpen = false;
                Debug.Log(" There are no Inventory");
            }

        }
    }

    public void otheritemOpen()
    {
        openChest();
        Destroy(this.gameObject);
    }

    private void Update()
    {
        player = GameObject.FindWithTag("PlayerControl").GetComponent<playerController>();
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<inventorySystem>();
        LSystem = GameObject.FindWithTag("GameController").GetComponent<lifeSystem>();
        if (isOpen == true & anim != null)
        {
            anim.SetBool("isOpen", true);
            IC.SetActive(false);
        }
        if (isOpen == true)
        {
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

    public void weightSystem()
    {
        //staminaItem
        if (this.gameObject.tag == "energyDrink")
        {
            LSystem.inventoryWeight = LSystem.inventoryWeight + 1;
        }
        if (this.gameObject.tag == "vitamin")
        {
            LSystem.inventoryWeight = LSystem.inventoryWeight + 1;
        }
        if (this.gameObject.tag == "dopping")
        {
            LSystem.inventoryWeight = LSystem.inventoryWeight + 2;
        }
        if (this.gameObject.tag == "wedangJahe")
        {
            LSystem.inventoryWeight = LSystem.inventoryWeight + 3;
        }
        if (this.gameObject.tag == "adrenaline")
        {
            LSystem.inventoryWeight = LSystem.inventoryWeight + 3;
        }
        if (this.gameObject.tag == "soda")
        {
            LSystem.inventoryWeight = LSystem.inventoryWeight + 2;
        }
        if (this.gameObject.tag == "botolAir")
        {
            LSystem.inventoryWeight = LSystem.inventoryWeight + 3;
        }
        if (this.gameObject.tag == "kopi")
        {
            LSystem.inventoryWeight = LSystem.inventoryWeight + 2;
        }
        if (this.gameObject.tag == "kopiJos")
        {
            LSystem.inventoryWeight = LSystem.inventoryWeight + 2;
        }
        if (this.gameObject.tag == "galonAir")
        {
            LSystem.inventoryWeight = LSystem.inventoryWeight + 5;
        }
        //healthItem

        //randomItem
        if (this.gameObject.tag == "supply")
        {
            LSystem.inventoryWeight = LSystem.inventoryWeight + 2;
        }
        if (this.gameObject.tag == "keyA")
        {
            LSystem.inventoryWeight = LSystem.inventoryWeight + 1;
        }
        if (this.gameObject.tag == "idCard")
        {
            LSystem.inventoryWeight = LSystem.inventoryWeight + 1;
        }
        if (this.gameObject.tag == "jerigen")
        {
            LSystem.inventoryWeight = LSystem.inventoryWeight + 5;
        }
        if (this.gameObject.tag == "kunciInggris")
        {
            LSystem.inventoryWeight = LSystem.inventoryWeight + 2;
        }



    }

}
