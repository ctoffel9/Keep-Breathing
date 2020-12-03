using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlPanel : MonoBehaviour
{
    public GameObject MiniGame;

    public void openMiniGame()
    {
        MiniGame.SetActive(true);
    }

    public void closeMiniGame()
    {
        MiniGame.SetActive(false);
    }

}
