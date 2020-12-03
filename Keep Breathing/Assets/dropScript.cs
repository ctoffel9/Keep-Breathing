using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropScript : MonoBehaviour
{

    public GameObject box1;
    public GameObject box2;
    public GameObject box3;
    public GameObject popUp;
    public int index;
    private void Start()
    {

        popUp.SetActive(false);
        box1.SetActive(false);
        box2.SetActive(false);
        box3.SetActive(false);
    }
    private void Update()
    {
        if (index == 1)
        {
            box1.SetActive(true);
        }
        if (index == 2)
        {
            box2.SetActive(true);
        }
        if (index == 3)
        {
            box3.SetActive(true);

        }
    }

    public void showPopUp()
    {
        popUp.SetActive(true);
    }
}
