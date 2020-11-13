using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SCM : MonoBehaviour
{
    public GameObject QP;
    public GameObject US;
    public GameObject LP;
    public GameObject PM;
    public GameObject IV;
    private bool IVopen = false;

    private lifeSystem ls;

    private void Start()
    {
        ls = GameObject.Find("gameSceneController").GetComponent<lifeSystem>();
    }
    private void Update()
    {
        if (ls.enabled)
        {
            US.SetActive(true);
        }
    }
    public void closeQuest()
    {
        QP.SetActive(false);
        if (ls.enabled)
        {
            US.SetActive(true);
        }
    }

    public void openQuest()
    {
        QP.SetActive(true);
        US.SetActive(false);
    }


    public void openInventory()
    {
        
        if (!IVopen)
        {
            IV.SetActive(true);
            IVopen = true;
        } else
        {
            IV.SetActive(false);
            IVopen = false;
        }
    }

    public void mainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
    public void Restart()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void resume()
    {
        PM.SetActive(false);
        Time.timeScale = 1;
    }

    public void pause()
    {
        PM.SetActive(true);
        Time.timeScale = 0;
    }
}
