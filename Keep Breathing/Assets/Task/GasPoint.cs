using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasPoint : MonoBehaviour
{
    [SerializeField] private GasTask task;

    private void Awake()
    {
        task = GetComponentInParent<GasTask>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        task.Point(this);
        Debug.Log("cet");
    }
}
