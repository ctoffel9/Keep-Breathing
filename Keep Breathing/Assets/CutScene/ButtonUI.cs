using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ButtonUI : MonoBehaviour, IPointerDownHandler
{
    public GameObject[] games;
    int i = 0;

    public void OnPointerDown(PointerEventData eventData)
    {
        nest();
    }

    public void nest()
    {
        if (i < games.Length)
        {
            games[i].SetActive(false);
            i++;
            games[i].SetActive(true);
        }
        else i = 0;
    }
}
