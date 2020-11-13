using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class package : MonoBehaviour
{
    public bool isOpen;
    public GameObject inventory;
    public GameObject Masker;
    public GameObject Tube;
    private lifeSystem ls;
    private void Start()
    {
        ls = GameObject.Find("gameSceneController").GetComponent<lifeSystem>();
    }
    public void takePackage()
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
            ls.enabled = true;
            inventory.SetActive(true);
            Masker.SetActive(true);
            Tube.SetActive(true);
            Destroy(this.gameObject);
        }
    }

}
