using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkTrigger : MonoBehaviour
{
    public int index;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Check"))
        {
            Debug.Log("test");
            index++;
        }

        if (index == 10)
        {
            Destroy(gameObject);
        }
    }
}
