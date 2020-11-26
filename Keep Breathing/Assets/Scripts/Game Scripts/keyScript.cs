using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyScript : MonoBehaviour
{
    private GameObject door;
    public string doortags;
    public void unlockDoor()
    {
        door = GameObject.FindGameObjectWithTag(doortags);
        if (door)
        {
            Debug.Log("found");
        }
        Destroy(door);
        Destroy(gameObject);
    }
}
