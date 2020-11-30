using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GasTask : MonoBehaviour
{
    public List<GasPoint> points = new List<GasPoint>();
    [SerializeField] Slider slider;
    private int index = 0;

    private void Awake()
    {
        slider = GetComponentInChildren<Slider>();

        slider.maxValue = 10f;
        slider.value = 0;
    }

    public void Point (GasPoint gasPoint)
    {
        slider.value++;
    }
    
}
