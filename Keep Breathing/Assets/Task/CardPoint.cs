using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardPoint : MonoBehaviour
{
    [SerializeField] private CardTask task;

    private void Awake()
    {
        task = GetComponentInParent<CardTask>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        task.SwipePointTrigger(this);
        Debug.Log("cet");
    }
}
