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
        StartCoroutine(type());
    }

    private void Update()
    {
        if(textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);
        }
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
        continueButton.SetActive(false);

        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(type());
        }
        else
        {
            textDisplay.text = "";
            continueButton.SetActive(false);
            this.gameObject.SetActive(false);
        }
    }
}
 