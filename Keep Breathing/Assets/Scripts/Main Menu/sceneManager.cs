using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{
	public AudioManager audioManager;
    public GameObject optionsPanel;

    void Start(){
    	audioManager = AudioManager.instance;
        if(audioManager == null){
            Debug.LogError("AudioManager tidak ada dalam Scene ini");
        }
    }

    public void newGame()
    {
        SceneManager.LoadScene("Intro");

    }

    public void level1()
    {
        SceneManager.LoadScene("Level 1");
        audioManager.Play("BGM in Game");
    }

    public void options()
    {
        optionsPanel.SetActive(true);  
    }

    public void closeoptions()
    {
        optionsPanel.SetActive(false);
    }

    public void selectLevel()
    {
        SceneManager.LoadScene("Select Chapter");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void ButtonHover(){
        audioManager.Play("hover");
    }

    public void ButtonClick(){
    	audioManager.Play("click");
    }
}
