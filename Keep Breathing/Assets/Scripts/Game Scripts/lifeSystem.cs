﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class lifeSystem : MonoBehaviour
{
    public GameObject player;
    public playerController pC;
    public SCM scm;

    public Text staminaView;
    public float stamina;
    private float StaminaDecrease;

    public Text maskQualityView;
    public float maskQuality;
    private float maskDecrease = 10f;
    public bool dangerZone;
    public bool maskerON;

    public Text healthView;
    public float health;
    private float healthDecrease;
    

    // Start is called before the first frame update
    void Start()
    {
        maskerON = true;
        healthDecrease = maskDecrease;
        Mathf.Clamp(stamina = 100, 0, 100);
        Mathf.Clamp(maskQuality = 100, 0, 100);
        Mathf.Clamp(health = 100, 0, 100);
    }

    // Update is called once per frame
    void Update()
    {

        staminaView.text = (Mathf.Floor(Mathf.Clamp(stamina, 0, 100)).ToString());
        maskQualityView.text = (Mathf.Floor(Mathf.Clamp(maskQuality, 0, 100)).ToString());
        healthView.text = (Mathf.Floor(Mathf.Clamp(health, 0, 100)).ToString());

        staminaSystem();
        if (maskerON == true)
        {
            maskerSystem();
        } 
        healthSystem();
        
    }
    void staminaSystem()
    {
        if (pC.run == true)
        {
            StaminaDecrease = 1;
        }
        else
        {
            StaminaDecrease = 0.1f;
        }
        if (pC.walk || pC.run == true && stamina > 0)
        {
            stamina = stamina - StaminaDecrease * Time.deltaTime;
        }
        if (stamina <= 0)
        {
            stamina = 0;
        }
        if (stamina > 100)
        {
            stamina = 100;
        }
        if (stamina == 0)
        {
            pC.exhaust = true;
        }
        if (pC.exhaust == true)
        {
            pC.anim.SetBool("capek", true);
            pC.walk = false;
            pC.run = false;
            pC.moving = false;
            if (stamina < 5)
            {
                stamina = stamina + 1 * Time.deltaTime;
            }
        }
        if (stamina >= 5)
        {
            pC.anim.SetBool("capek", false);
            pC.exhaust = false;
            pC.moving = true;
        }
    }
    void maskerSystem()
    {
        if (maskQuality <= 0)
        {
            maskQuality = 0;
        }
        if (maskQuality > 100)
        {
           maskQuality = 100;
        }
            if (dangerZone && maskQuality > 0)
        {
            maskQuality = maskQuality - maskDecrease * Time.deltaTime;
        }
    }
    void healthSystem()
    {
        if (health <= 0)
        {
            health = 0;
        }
        if (health > 100)
        {
            health = 100;
        }
        if (maskerON == false | maskQuality <= 0 && dangerZone == true && health > 0)
        {
            health = health - healthDecrease * Time.deltaTime;
        }
        if (health == 0 || health < 0)
        {
            Debug.Log("Player is not breathing");
            scm.LP.SetActive(true);
            scm.US.SetActive(false);
           
            
        }
    }
}