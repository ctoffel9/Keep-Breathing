using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelManager : MonoBehaviour
{
    private dropScript DScript;
    private codeBarScripts cbScripts;
    public GameObject[] pakYudha;
    public GameObject[] teknisi;
    public GameObject[] keyBoard;


    private void Start()
    {
        //Pak yudha
        pakYudha[0].SetActive(true);
        pakYudha[1].SetActive(false);

        //Teknisi
        teknisi[0].SetActive(false);
        teknisi[1].SetActive(false);

        //keyBoard
        keyBoard[0].SetActive(true);
        keyBoard[1].SetActive(false);

        DScript = GameObject.FindGameObjectWithTag("dropPlace").GetComponent<dropScript>();

    }

    private void Update()
    {
        cbScripts = GameObject.FindGameObjectWithTag("codeBar").GetComponent<codeBarScripts>();
        if (DScript.index == 3)
        {
            Destroy(pakYudha[0]);
            pakYudha[1].SetActive(true);

            teknisi[0].SetActive(true);

            Destroy(keyBoard[0]);
            keyBoard[1].SetActive(true);

        }
        if (cbScripts != null)
        {
            if (cbScripts.controlPanelON)
            {
                Destroy(teknisi[0]);
                teknisi[1].SetActive(true);
            }
        }
      
    }
}
