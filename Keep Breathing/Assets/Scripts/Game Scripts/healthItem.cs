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
    }
    public void firstAidKit()
    {
        LS.health = LS.health + 30;
        Destroy(gameObject);
    }
    public void makananKaleng()
    {
        LS.health = LS.health + 3;
        Destroy(gameObject);
    }
    public void antibiotic()
    {
        LS.health = LS.health + 15;
        Destroy(gameObject);
    }
    public void roti()
    {
        LS.health = LS.health + 4;
        Destroy(gameObject);
    }
    public void snackbar()
    {
        LS.health = LS.health + 6;
        Destroy(gameObject);
    }
    public void nasdukSB()
    {
        LS.health = LS.health + 15;
        Destroy(gameObject);
    }
    public void naspadSB()
    {
        LS.health = LS.health + 30;
        Destroy(gameObject);
    }
    public void jagung()
    {
        LS.health = LS.health + 5;
        Destroy(gameObject);
    }
    public void kacang()
    {
        LS.health = LS.health + 3;
        Destroy(gameObject);
    }
    public void miInstan()
    {
        LS.health = LS.health + 8;
        Destroy(gameObject);
    }
}
