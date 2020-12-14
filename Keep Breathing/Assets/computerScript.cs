using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class computerScript : MonoBehaviour
{
    public InputField input;
    public GameObject errorNotif;
    private levelManager LM;

    private void Start()
    {
        LM = GameObject.FindWithTag("levelManager").GetComponent<levelManager>();
    }
    public void GetInput(string answer)
    {
        if (answer == "True")
        {
            LM.exactCode = true;
            Debug.Log("anjayani");
            errorNotif.SetActive(true);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
