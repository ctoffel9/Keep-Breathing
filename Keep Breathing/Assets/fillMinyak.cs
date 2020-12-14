using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fillMinyak : MonoBehaviour
{
    public Image gasFill;
    public float gas = 0;
    public bool full;
    private levelManager lManager;
    public GameObject fullSound;

    private void Start()
    {
        fullSound.SetActive(false);
    }
    private void Update()
    {
        gasFill.fillAmount = gas / 100;

        if (gas >= 100)
        {
            gas = 100;
            full = true;
            lManager = GameObject.FindGameObjectWithTag("levelManager").GetComponent<levelManager>();
            lManager.end = true;
            fullSound.SetActive(true);
        }

    }

    public void fillingGas()
    {
        gas++;
    }

}
