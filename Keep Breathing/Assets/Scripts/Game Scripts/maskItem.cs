using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maskItem : MonoBehaviour
{
    private lifeSystem LS;
    private void Start()
    {
        LS = GameObject.FindWithTag("GameController").GetComponent<lifeSystem>();
    }
    public void botolAir()
    {
        LS.maskQuality = LS.maskQuality + 20;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 3;
    }
    public void galonAir()
    {
        LS.maskQuality = LS.maskQuality + 35;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 5;
    }
    public void filter()
    {
        LS.maskQuality = LS.maskQuality + 10;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 1;
    }
    public void filterN95()
    {
        LS.maskQuality = LS.maskQuality + 15;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 2;
    }
    public void filterN100()
    {
        LS.maskQuality = LS.maskQuality + 25;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 2;
    }
    public void filterP95()
    {
        LS.maskQuality = LS.maskQuality + 50;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 2;
    }
    public void baterai9V()
    {
        LS.maskQuality = LS.maskQuality + 50;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 3;
    }
    public void bateraiC()
    {
        LS.maskQuality = LS.maskQuality + 25;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 2;
    }
    public void bateraiAA()
    {
        LS.maskQuality = LS.maskQuality + 15;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 1;
    }
    public void purifier()
    {
        LS.maskQuality = LS.maskQuality + 10;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 3;
    }

}
