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

    private void Start()
    {
        whosTalking.text = theOneTalking;
        StartCoroutine(type());
    }

    IEnumerator type()
    {
        foreach(char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);

        }
    }
}
 