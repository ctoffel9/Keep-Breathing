using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selesai : MonoBehaviour
{
    public GameObject winPanel;
    public GameObject US;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            winPanel.SetActive(true);
            US.SetActive(false);

        }
    }
}
