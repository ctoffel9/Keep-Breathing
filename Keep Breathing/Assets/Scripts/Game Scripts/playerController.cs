using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private float speed = 4;
    public float jumpforce;
    public GameObject digta;
    public Animator anim;
    public bool walk = false;
    public bool run = false;
    public bool exhaust = false;
    public bool moving = true;
    public AudioSource walkSound;
    public AudioSource runSound;
    public int key;
    public bool adaKunci;

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (walk == true)
        {
            anim.SetBool("isWalking", true);
            if (!walkSound.isPlaying && !runSound.isPlaying)
            {
                walkSound.Play();
            }
        } else
        {
            anim.SetBool("isWalking", false);
            if (walkSound.isPlaying)
            {
                walkSound.Pause();
            }
        }

        if (Input.GetKey(KeyCode.LeftShift) && walk == true)
        {
            speed = 10;
            run = true;
            anim.SetBool("isRunning", true);
            if (!runSound.isPlaying)
            {
                runSound.Play();
                walkSound.Stop();
            }
        }
        else
        {
            speed = 4;
            run = false;
            anim.SetBool("isRunning", false);
            if (runSound.isPlaying)
            {
                runSound.Pause();
            }
        }
        if (moving == true)
        {
            movement();
        }

       
    }

    void movement()
    {
        //Ini Skrip untuk pergerakkan player
        //Quarternion digunakan untuk men-flip game object\

        if (Input.GetKey("w"))
        {
            walk = true;
            this.gameObject.transform.Translate(Vector3.forward * speed * Time.deltaTime);
            digta.gameObject.transform.rotation = Quaternion.Euler(0, -90, 0);
            
        }
        else
        {
            walk = false;
        }
        if (Input.GetKey("s"))
        {
            walk = true;
            this.gameObject.transform.Translate(Vector3.back * speed * Time.deltaTime);
            digta.gameObject.transform.rotation = Quaternion.Euler(0, 90, 0);
        }
        if (Input.GetKey("d"))
        {
            walk = true;
            this.gameObject.transform.Translate(Vector3.right * speed * Time.deltaTime);
            digta.gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            walk = true;
            this.gameObject.transform.Translate(Vector3.left * speed * Time.deltaTime);
            digta.gameObject.transform.rotation = Quaternion.Euler(0, 180, 0);
        }
    }

}
