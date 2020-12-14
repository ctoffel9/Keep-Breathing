using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthItem : MonoBehaviour
{
    private lifeSystem LS;
    private void Start()
    {
        LS = GameObject.FindWithTag("GameController").GetComponent<lifeSystem>();
    }
    public void bandage()
    {
        LS.health = LS.health + 5;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 1;
    }
    public void firstAidKit()
    {
        LS.health = LS.health + 30;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 3;
    }
    public void makananKaleng()
    {
        LS.health = LS.health + 3;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 2;
    }
    public void antibiotic()
    {
        LS.health = LS.health + 15;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 1;
    }
    public void roti()
    {
        LS.health = LS.health + 4;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 1;
    }
    public void snackBar()
    {
        LS.health = LS.health + 6;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 1;
    }
    public void nasdukSB()
    {
        LS.health = LS.health + 15;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 3;
    }
    public void naspadSB()
    {
        LS.health = LS.health + 30;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 5;
    }
    public void jagung()
    {
        LS.health = LS.health + 5;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 2;
    }
    public void kacang()
    {
        LS.health = LS.health + 3;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 1;
    }
    public void miInstan()
    {
        LS.health = LS.health + 8;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 2;
    }
}
