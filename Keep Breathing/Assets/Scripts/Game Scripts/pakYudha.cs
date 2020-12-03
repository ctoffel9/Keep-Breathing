using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pakYudha : MonoBehaviour
{
    public GameObject DialogueBox0;


    private void Start()
    {
        DialogueBox0.SetActive(false);

    }
    public void pakYudhaDialogue()
    {
            DialogueBox0.SetActive(true);
    }
}
