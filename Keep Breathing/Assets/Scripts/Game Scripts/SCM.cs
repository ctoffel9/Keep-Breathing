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
   public void closeQuest()
    {
        QP.SetActive(false);
        US.SetActive(true);
    }

    public void openQuest()
    {
        QP.SetActive(true);
        US.SetActive(false);
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
