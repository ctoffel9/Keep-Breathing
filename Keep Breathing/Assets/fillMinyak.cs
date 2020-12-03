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


    private void Update()
    {
        gasFill.fillAmount = gas / 100;

        if (gas >= 100)
        {
            gas = 100;
            full = true;
            lManager = GameObject.FindGameObjectWithTag("levelManager").GetComponent<levelManager>();
            lManager.end = true;
        }

    }

    public void fillingGas()
    {
        gas++;
    }

}
