using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthItem : MonoBehaviour
{
    private lifeSystem LS;
    private SCM scm;
    private void Start()
    {
        scm = GameObject.FindWithTag("GameController").GetComponent<SCM>();
        LS = GameObject.FindWithTag("GameController").GetComponent<lifeSystem>();
    }
    public void bandage()
    {
        LS.health = LS.health + 5;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 1;
        scm.itemSound.Play();
    }
    public void firstAidKit()
    {
        LS.health = LS.health + 30;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 3;
        scm.itemSound.Play();
    }
    public void makananKaleng()
    {
        LS.health = LS.health + 3;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 2;
        scm.itemSound.Play();
    }
    public void antibiotic()
    {
        LS.health = LS.health + 15;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 1;
        scm.itemSound.Play();
    }
    public void roti()
    {
        LS.health = LS.health + 4;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 1;
        scm.itemSound.Play();
    }
    public void snackBar()
    {
        LS.health = LS.health + 6;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 1;
        scm.itemSound.Play();
    }
    public void nasdukSB()
    {
        LS.health = LS.health + 15;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 3;
        scm.itemSound.Play();
    }
    public void naspadSB()
    {
        LS.health = LS.health + 30;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 5;
        scm.itemSound.Play();
    }
    public void jagung()
    {
        LS.health = LS.health + 5;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 2;
        scm.itemSound.Play();
    }
    public void kacang()
    {
        LS.health = LS.health + 3;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 1;
        scm.itemSound.Play();
    }
    public void miInstan()
    {
        LS.health = LS.health + 8;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 2;
        scm.itemSound.Play();

    }
}
