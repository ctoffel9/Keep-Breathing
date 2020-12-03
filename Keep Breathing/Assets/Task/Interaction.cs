using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interaction : MonoBehaviour
{
    public bool isInRange;
    public KeyCode interactive;
    public UnityEvent interactAction;
    public GameObject notify;

    // Start is called before the first frame update
    void Start()
    {
        notify.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (isInRange)
        {
            if (Input.GetKeyDown(interactive))
            {
                interactAction.Invoke();
            }
        }
    }
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isInRange = true;
            notify.SetActive(true);
            Debug.Log("Player now is in range");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isInRange = false;
            Debug.Log("Player now is not in range");
            notify.SetActive(false);
        }
    }
}
