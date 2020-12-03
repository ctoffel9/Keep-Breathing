using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomItem : MonoBehaviour
{
    private GameObject door;
    private interactable IR;
    private lifeSystem LS;
    public string tags;

    private dropScript dropPlace;

    private void Start()
    {
        LS = GameObject.FindWithTag("GameController").GetComponent<lifeSystem>();
    }
    public void unlockDoor()
    {
        door = GameObject.FindGameObjectWithTag(tags);
        IR = GameObject.FindGameObjectWithTag(tags).GetComponentInChildren<interactable>();
        if (door & IR.isInRange )
        {
            Destroy(door);
            Destroy(gameObject);
            Debug.Log("found");
            LS.inventoryWeight = LS.inventoryWeight - 1;
        }
       
    }
    public void supply()
    {
        dropPlace = GameObject.FindGameObjectWithTag(tags).GetComponent<dropScript>();
        IR = GameObject.FindGameObjectWithTag(tags).GetComponentInChildren<interactable>();
        if (dropPlace & IR.isInRange)
        {
            dropPlace.index = dropPlace.index + 1;
            Destroy(gameObject);
            LS.inventoryWeight = LS.inventoryWeight - 2;
        }

    }
}
