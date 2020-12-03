using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftScript : MonoBehaviour
{
    public Animator anim;
    public GameObject Player;
    public void buttonUp()
    {
        anim.SetTrigger("Up");
    }
    public void buttonDown()
    {
        anim.SetTrigger("Down");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player)
        {
            Debug.Log("Player");
            Player.transform.parent = transform;
        }
    }
}
