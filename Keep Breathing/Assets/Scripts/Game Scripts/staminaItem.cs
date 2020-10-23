using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class staminaItem : MonoBehaviour
{
    private lifeSystem LS;
    private void Start()
    {
        LS = GameObject.FindWithTag("GameController").GetComponent<lifeSystem>();
    }
    public void energyDrink()
    {
        LS.stamina = LS.stamina + 30;
        Destroy(gameObject);
    }
}
