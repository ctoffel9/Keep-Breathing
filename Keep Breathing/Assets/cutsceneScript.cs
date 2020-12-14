using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cutsceneScript : sceneManager
{

    public GameObject[] Scene;
    public int index;
    public int indexScene;
    public Animator anim;


    private void Start()
    {
        index = 0;
    }

    private void Update()
    {
        Scene[index].SetActive(true);
    }

    public void next()
    {
            index++;
        if (index > Scene.Length - 1)
        {
            //SceneManager.LoadScene("Level" + " " + indexScene );
            if (indexScene == 1)
            {
                level1();
            }
            if (indexScene == 2)
            {
                level2();
            }
            if (indexScene == 3)
            {
                level3();
            }
        }
    }

    public void nextEnd()
    {
        index++;
        if (index > Scene.Length - 1)
        {
            MainMenuSC();
        }
    }
}

