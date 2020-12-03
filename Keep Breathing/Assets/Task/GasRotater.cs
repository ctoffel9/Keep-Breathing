using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class GasRotater : MonoBehaviour, IDragHandler
{
    [SerializeField]RectTransform rect;
    public float rotspeed = 0.5f;

    private void Awake()
    {
        rect = GetComponent<RectTransform>();
    }

    public void OnDrag(PointerEventData eventData)
    {
        float rotater = Mathf.Atan2(eventData.position.y, eventData.position.x) * Mathf.Rad2Deg -27;
        rect.rotation = Quaternion.Slerp(rect.rotation, Quaternion.Euler(0,0,rotater) , rotspeed * Time.deltaTime);
    }

    public float Value()
    {
        return rect.transform.eulerAngles.z;
    }
}
