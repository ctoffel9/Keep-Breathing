using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{
    private SCM SceneContromM;
    public Animator transitionAnim;
    private SCM scm;
    public GameObject MC;

    public GameObject optionsPanel;

    private void Awake()
    {
        
    }
    private void Start()
    {
    }
    public void newGame()
    {
        StartCoroutine(NGame());

    }

    public void level1()
    {
        StartCoroutine(L1());

    }

    public void level2()
    {
        StartCoroutine(L2());
    }

    public void level3()
    {
        StartCoroutine(L3());
    }

    public void cutScene1()
    {
        StartCoroutine(CS1());
    }

    public void cutScene2()
    {
        StartCoroutine(CS2());
    }

    public void cutScene3()
    {
        StartCoroutine(CS3());
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
        StartCoroutine(SL());
    }

    public void MainMenu()
    {
        StartCoroutine(MM());
    }

    public void MainMenuSC()
    {

        StartCoroutine(MMsc());
    }

    public void Credits()
    {

        StartCoroutine(CRD());
    }

    public void Exit()
    {

        StartCoroutine(X());
    }

    public void closePause()
    {
        SceneContromM = GameObject.FindWithTag("GameController").GetComponent<SCM>();
        SceneContromM.PM.SetActive(false);
        Time.timeScale = 1;
    }

    IEnumerator NGame()
    {
        transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene("Intro");

    }
    IEnumerator L1()
    {
        transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene("level 1");

    }

    IEnumerator L2()
    {
        transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene("level 2");

    }
    IEnumerator L3()
    {
        transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene("level 3");

    }
    IEnumerator MM()
    {
        scm = GameObject.FindGameObjectWithTag("GameController").GetComponent<SCM>();
        if (scm != null)
        {
            scm.PM.SetActive(false);
        }
        Time.timeScale = 1;
        transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("Main Menu");

    }

    IEnumerator MMsc()
    {
        transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("Main Menu");

    }

    IEnumerator SL()
    {
        transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("Select Chapter");

    }

    IEnumerator CS1()
    {
        transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("cutScene1");

    }

    IEnumerator CS2()
    {
        transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("cutScene2");

    }
    IEnumerator CS3()
    {
        transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("cutScene3");

    }

    IEnumerator CRD()
    {
        transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("Credits");

    }

    IEnumerator X()
    {
        transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        Application.Quit();

    }
}
