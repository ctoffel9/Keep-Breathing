using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class staminaItem : MonoBehaviour
{
    private lifeSystem LS;
    private AudioSource AS;
    private void Start()
    {
        LS = GameObject.FindWithTag("GameController").GetComponent<lifeSystem>();

    }
    public void energyDrink()
    {
        LS.stamina = LS.stamina + 20;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 1;
    }
    public void vitamin()
    {
        LS.stamina = LS.stamina + 5;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 1;
    }

    public void dopping()
    {
        LS.stamina = LS.stamina + 10;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 2;
    }
    public void wedangJahe()
    {
        LS.stamina = LS.stamina + 15;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 3;
    }
    public void adrenaline()
    {
        LS.stamina = LS.stamina + 15;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 3;
    }
    public void soda()
    {
        LS.stamina = LS.stamina + 10;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 2;
    }
    public void botolAir()
    {
        LS.stamina = LS.stamina + 20;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 3;
    }
    public void kopi()
    {
        LS.stamina = LS.stamina + 15;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 2;
    }
    public void kopiJos()
    {
        LS.stamina = LS.stamina + 20;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 2;
    }
    public void galonAir()
    {
        LS.stamina = LS.stamina + 35;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 5;
    }
}
