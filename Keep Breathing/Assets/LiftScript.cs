using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftScript : MonoBehaviour
{
    public Animator anim;
    public Transform cube;
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
            Player.transform.parent.position = cube.transform.position;
        }
    }
}
