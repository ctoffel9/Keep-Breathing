using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpSystem : MonoBehaviour
{
    private inventorySystem inventory;
    public GameObject itemButton;
    bool inventOn;

    private void Start()
    {
        inventOn = false;
       
    }

    private void Update()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<inventorySystem>();
        if (inventOn)
        {
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {
                    inventory.isFull[i] = true;
                    Instantiate(itemButton, inventory.slots[i].transform);
                    Destroy(gameObject);
                    break;

                }

            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (inventory != null)
            {
                inventOn = true;
                Debug.Log("ada inventorynya");
            } else
            {
                inventOn = false;
                Debug.Log("kagak ada inventorynya");
            }
            
        } 
    }
}
