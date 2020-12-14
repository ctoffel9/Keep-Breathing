using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maskItem : MonoBehaviour
{
    private lifeSystem LS;
    private SCM scm;
    private void Start()
    {
        scm = GameObject.FindWithTag("GameController").GetComponent<SCM>();
        LS = GameObject.FindWithTag("GameController").GetComponent<lifeSystem>();
    }
    public void botolAir()
    {
        LS.maskQuality = LS.maskQuality + 20;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 3;
        scm.itemSound.Play();
    }
    public void galonAir()
    {
        LS.maskQuality = LS.maskQuality + 35;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 5;
        scm.itemSound.Play();
    }
    public void filter()
    {
        LS.maskQuality = LS.maskQuality + 10;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 1;
        scm.itemSound.Play();
    }
    public void filterN95()
    {
        LS.maskQuality = LS.maskQuality + 15;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 2;
        scm.itemSound.Play();
    }
    public void filterN100()
    {
        LS.maskQuality = LS.maskQuality + 25;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 2;
        scm.itemSound.Play();
    }
    public void filterP95()
    {
        LS.maskQuality = LS.maskQuality + 50;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 2;
        scm.itemSound.Play();
    }
    public void baterai9V()
    {
        LS.maskQuality = LS.maskQuality + 50;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 3;
        scm.itemSound.Play();
    }
    public void bateraiC()
    {
        LS.maskQuality = LS.maskQuality + 25;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 2;
        scm.itemSound.Play();
    }
    public void bateraiAA()
    {
        LS.maskQuality = LS.maskQuality + 15;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 1;
        scm.itemSound.Play();
    }
    public void purifier()
    {
        LS.maskQuality = LS.maskQuality + 10;
        Destroy(gameObject);
        LS.inventoryWeight = LS.inventoryWeight - 3;
        scm.itemSound.Play();
    }

}
