using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{
    public GameObject optionsPanel;
    public void newGame()
    {
        SceneManager.LoadScene("Intro");
    }

    public void level1()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void options()
    {
        optionsPanel.SetActive(true);   
    }

    public void closeoptions()
    {
        optionsPanel.SetActive(false);
    }

}
