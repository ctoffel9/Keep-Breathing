using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seeker : MonoBehaviour
{
    public Transform state;
    // Start is called before the first frame update
    void Start()
    {
        GameObject objToSpawn;
        objToSpawn = new GameObject("AnjayBisa");
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Transform child in state) if (child.CompareTag("maumere"))
            {
                Debug.Log("Found");
            }
    }
}
