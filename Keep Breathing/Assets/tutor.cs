using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutor : MonoBehaviour
{
    public GameObject[] images;
    public int index=0;
    public GameObject next;
    public GameObject prev;


    private void Update()
    {
        if (index == images.Length - 1)
        {
            next.SetActive(false);
        } else
        {
            next.SetActive(true);
        }
        if (index == 0)
        {
            prev.SetActive(false);
        } else
        {
            prev.SetActive(true);
        }

        images[index].SetActive(true);
    }

    public void nextImages()
    {
        if (index != images.Length - 1)
        {
            index++;
        }
    }
    public void prevImages()
    {
        Destroy(this.gameObject);
    }
}
