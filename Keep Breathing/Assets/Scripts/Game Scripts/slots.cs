using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slots : MonoBehaviour
{
    private inventorySystem inventory;
    public int i;
    public void Update()
    {
        inventory = GameObject.FindWithTag("Player").GetComponentInChildren<inventorySystem>();

        if (transform.childCount <= 0 && inventory != null)
        {
            inventory.isFull[i] = false;
        }
    }
    public void dropItem()
    {
        foreach (Transform child in transform)
        {
            GameObject.Destroy(child.gameObject);
        }
    }
}
