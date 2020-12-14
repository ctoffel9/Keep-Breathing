using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomItem : MonoBehaviour
{
    private GameObject door;
    private GameObject doorPipa;
    private interactable IR;
    private lifeSystem LS;
    public string tags;

    private dropScript dropPlace;
    private controlPanel cPanel;
    private controlPanel cPanel2;
    private levelManager lManager;
    private SCM scm;

    private void Start()
    {
        scm = GameObject.FindWithTag("GameController").GetComponent<SCM>();
        LS = GameObject.FindWithTag("GameController").GetComponent<lifeSystem>();
        lManager = GameObject.FindWithTag("levelManager").GetComponent<levelManager>();

        if (lManager.level2)
        {
            cPanel = GameObject.FindWithTag("jerigenMinyak").GetComponent<controlPanel>();
            cPanel2 = GameObject.FindWithTag("pipa").GetComponent<controlPanel>();
        }
        
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
            scm.itemSound.Play();
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
            scm.itemSound.Play();
        }

    }

    public void idcard()
    {
        door = GameObject.FindGameObjectWithTag(tags);
        IR = GameObject.FindGameObjectWithTag(tags).GetComponentInChildren<interactable>();
        if (door & IR.isInRange)
        {
            Destroy(door);
            Destroy(gameObject);
            Debug.Log("found");
            LS.inventoryWeight = LS.inventoryWeight - 1;
            scm.itemSound.Play();
        }
    }

    public void jerigen()
    {
        door = GameObject.FindGameObjectWithTag(tags);
        IR = GameObject.FindGameObjectWithTag(tags).GetComponentInChildren<interactable>();
        if (door & IR.isInRange)
        {
            cPanel.MiniGame.SetActive(true);
            Debug.Log("found");
            LS.inventoryWeight = LS.inventoryWeight + 5;
            scm.itemSound.Play();
        }
    }

    public void kunciInggris()
    {
        door = GameObject.FindGameObjectWithTag(tags);
        IR = GameObject.FindGameObjectWithTag(tags).GetComponentInChildren<interactable>();
        if (door & IR.isInRange)
        {
            Destroy(door);
            Destroy(gameObject);
            Debug.Log("found");
            LS.inventoryWeight = LS.inventoryWeight - 2;
            scm.itemSound.Play();
        }

    }

    public void kunciPipa()
    {
        door = GameObject.FindGameObjectWithTag(tags);
        doorPipa = GameObject.Find("DoorPipa");
        IR = GameObject.FindGameObjectWithTag(tags).GetComponentInChildren<interactable>();
        if (door & IR.isInRange)
        {
            cPanel2.MiniGame.SetActive(true);
            Destroy(doorPipa);
            Destroy(gameObject);
            Debug.Log("found");
            LS.inventoryWeight = LS.inventoryWeight - 2;
            scm.itemSound.Play();
        }

    }
}
