using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PassLock : MonoBehaviour
{
    public TextMeshProUGUI card;
    public TextMeshProUGUI text;
    public int length = 6;
    public float resetTime = 1f;
    public bool reset = false;

    private void OnEnable()
    {
        string code = string.Empty;

        for (int i = 0; i < length; i++)
        {
            code += Random.Range(0, 10);
        }

        card.text = code;
        text.text = string.Empty;
    }

    public void ButtonClick(int number)
    {
        if (reset) return;

        text.text += number;

        if(text.text == card.text)
        {
            text.text = "Correct";
            StartCoroutine(Reset());
        }else if (text.text.Length >= length)
        {
            text.text = "Failed";
            StartCoroutine(Reset());
        }
    }
    IEnumerator Reset()
    {
        reset = true;
        yield return new WaitForSeconds(resetTime);
        text.text = string.Empty;
        reset = false;
    }
}
