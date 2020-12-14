using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baling : MonoBehaviour
{
    private float zRotation;
    public GameObject balings;
    private void Update()
    {
        balings.transform.Rotate(new Vector3(0f, 0f, 50f));
    }
}
