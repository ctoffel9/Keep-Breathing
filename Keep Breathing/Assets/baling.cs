﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baling : MonoBehaviour
{
    private float zRotation;
    public GameObject balings;
    private levelManager LM;

    private void Start()
    {
        LM = GameObject.FindWithTag("levelManager").GetComponent<levelManager>();

    }
    private void Update()
    {
        if (LM.switchOn)
        {
            balings.transform.Rotate(new Vector3(0f, 0f, 50f)); 
        }
        
    }
}