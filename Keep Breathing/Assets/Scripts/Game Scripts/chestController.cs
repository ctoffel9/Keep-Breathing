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
    public GameObject[] itemArray;
    public GameObject IC;
    public GameObject DM;
    private int random;
    public int randomR;
    public bool thisIsItemVariant;
    bool inventOn;


    private void Awake()
    {
            random = Random.Range(0, itemArray.Length);
    }
    private void Start()
    {
        DM.SetActive(false);
        
        
        randomR = random;
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
    public void openChestRandom()
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
                        Instantiate(itemArray[randomR], inventory.slots[i].transform);
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

        if (thisIsItemVariant == true)
        {
            this.gameObject.tag = itemArray[random].tag;
        }
        else if (thisIsItemVariant == false)
        {
            this.gameObject.tag = itemButton.tag;
        }
        Debug.Log(randomR);
        Debug.Log(this.gameObject.tag);
        
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
        /*if (this.gameObject.tag == "botolAir")
        {
            LSystem.inventoryWeight = LSystem.inventoryWeight + 3;
        }*/
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
        if (this.gameObject.tag == "bandage")
        {
            LSystem.inventoryWeight = LSystem.inventoryWeight + 1;
        }
        if (this.gameObject.tag == "firstAidKit")
        {
            LSystem.inventoryWeight = LSystem.inventoryWeight + 3;
        }
        if (this.gameObject.tag == "makananKaleng")
        {
            LSystem.inventoryWeight = LSystem.inventoryWeight + 2;
        }
        if (this.gameObject.tag == "antiBiotic")
        {
            LSystem.inventoryWeight = LSystem.inventoryWeight + 1;
        }
        if (this.gameObject.tag == "roti")
        {
            LSystem.inventoryWeight = LSystem.inventoryWeight + 1;
        }
        if (this.gameObject.tag == "snackBar")
        {
            LSystem.inventoryWeight = LSystem.inventoryWeight + 1;
        }
        if (this.gameObject.tag == "nasdukSB")
        {
            LSystem.inventoryWeight = LSystem.inventoryWeight + 3;
        }
        if (this.gameObject.tag == "naspadSB")
        {
            LSystem.inventoryWeight = LSystem.inventoryWeight + 5;
        }
        if (this.gameObject.tag == "jagung")
        {
            LSystem.inventoryWeight = LSystem.inventoryWeight + 2;
        }
        if (this.gameObject.tag == "kacang")
        {
            LSystem.inventoryWeight = LSystem.inventoryWeight + 1;
        }
        if (this.gameObject.tag == "miInstan")
        {
            LSystem.inventoryWeight = LSystem.inventoryWeight + 2;
        }

        //maskItem
        if (this.gameObject.tag == "botolAir")
        {
            LSystem.inventoryWeight = LSystem.inventoryWeight + 3;
        }
        /*if (this.gameObject.tag == "galonAir")
        {
            LSystem.inventoryWeight = LSystem.inventoryWeight + 5;
        }*/
        if (this.gameObject.tag == "filter")
        {
            LSystem.inventoryWeight = LSystem.inventoryWeight + 1;
        }
        if (this.gameObject.tag == "filterN95")
        {
            LSystem.inventoryWeight = LSystem.inventoryWeight + 2;
        }
        if (this.gameObject.tag == "filterN100")
        {
            LSystem.inventoryWeight = LSystem.inventoryWeight + 2;
        }
        if (this.gameObject.tag == "filterP95")
        {
            LSystem.inventoryWeight = LSystem.inventoryWeight + 2;
        }
        if (this.gameObject.tag == "baterai9V")
        {
            LSystem.inventoryWeight = LSystem.inventoryWeight + 3;
        }
        if (this.gameObject.tag == "bateraiC")
        {
            LSystem.inventoryWeight = LSystem.inventoryWeight + 2;
        }
        if (this.gameObject.tag == "bateraiAA")
        {
            LSystem.inventoryWeight = LSystem.inventoryWeight + 1;
        }
        if (this.gameObject.tag == "purifier")
        {
            LSystem.inventoryWeight = LSystem.inventoryWeight + 3;
        }
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
