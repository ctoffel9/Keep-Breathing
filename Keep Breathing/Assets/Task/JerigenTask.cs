using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JerigenTask : MonoBehaviour
{
    [SerializeField] Slider slider;
    private float index = 0;

    private void Awake()
    {
        slider = GetComponentInChildren<Slider>();

        slider.maxValue = 10f;
        slider.value = 0;
    }
    public void ButtonClick(float number)
    {
        slider.value += number;
    }
}
