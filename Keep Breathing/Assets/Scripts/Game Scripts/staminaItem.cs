using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class staminaItem : MonoBehaviour
{
    private lifeSystem LS;
    private SCM scm;
    private void Start()
    {
        scm = GameObject.FindWithTag("GameController").GetComponent<SCM>();
        LS = GameObject.FindWithTag("GameController").GetComponent<lifeSystem>();

    }
    public void energyDrink()
    {
        LS.stamina = LS.stamina + 20;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 1;
        scm.itemSound.Play();
    }
    public void vitamin()
    {
        LS.stamina = LS.stamina + 5;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 1;
        scm.itemSound.Play();
    }

    public void dopping()
    {
        LS.stamina = LS.stamina + 10;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 2;
        scm.itemSound.Play();
    }
    public void wedangJahe()
    {
        LS.stamina = LS.stamina + 15;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 3;
        scm.itemSound.Play();
    }
    public void adrenaline()
    {
        LS.stamina = LS.stamina + 15;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 3;
        scm.itemSound.Play();
    }
    public void soda()
    {
        LS.stamina = LS.stamina + 10;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 2;
        scm.itemSound.Play();
    }
    public void botolAir()
    {
        LS.stamina = LS.stamina + 20;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 3;
        scm.itemSound.Play();
    }
    public void kopi()
    {
        LS.stamina = LS.stamina + 15;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 2;
        scm.itemSound.Play();
    }
    public void kopiJos()
    {
        LS.stamina = LS.stamina + 20;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 2;
        scm.itemSound.Play();
    }
    public void galonAir()
    {
        LS.stamina = LS.stamina + 35;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 5;
        scm.itemSound.Play();
    }
}
