using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameSceneController : MonoBehaviour
{
    public Camera MainCamera;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MainCamera.transform.position = new Vector3(Player.transform.position.x + 5F, Player.transform.position.y + 5, MainCamera.transform.position.z);
    }
}
