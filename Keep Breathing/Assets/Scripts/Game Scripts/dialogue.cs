using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class dialogue : MonoBehaviour
{
    public Text textDisplay;
    public Text whosTalking;
    [TextArea]
    public string theOneTalking;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    public GameObject continueButton;

    private void Start()
    {
        whosTalking.text = theOneTalking;
        textDisplay.text = sentences[0];
        //StartCoroutine(type());
    }

    private void Update()
    {
        textDisplay.text = sentences[index];
    }

    IEnumerator type()
    {
        foreach(char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);

        }
    }

    public void nextSentence()
    {
        if (index < sentences.Length - 1)
        {
            index++;
        }
        else if (index == sentences.Length - 1)
        {
            this.gameObject.SetActive(false);
        }


        //continueButton.SetActive(false);

        /*if (index < sentences.Length - 1)
        {
            index++;
            //textDisplay.text = "";
            //StartCoroutine(type());
        }
        else 
        {
            textDisplay.text = "...";
        //    continueButton.SetActive(false);
            this.gameObject.SetActive(false);
        }*/
    }

    public void hide()
    {
        this.gameObject.SetActive(false);
    }
}
 