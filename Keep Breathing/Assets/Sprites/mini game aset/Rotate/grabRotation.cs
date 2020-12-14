 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.EventSystems;

public class grabRotation : MonoBehaviour, IDragHandler {

    private float zAxisRotation;
    public GameObject thisGameObject;
    private checkTrigger trigger;

    private void Start()
    {
        trigger = GameObject.Find("Trigger").GetComponent<checkTrigger>();
    }
    public void OnDrag(PointerEventData eventData)
    {
        if (trigger.index != 10)
        {
            Debug.Log("dragging");
            thisGameObject.transform.Rotate(new Vector3(0, 0, -2f));
        }
    }



}
