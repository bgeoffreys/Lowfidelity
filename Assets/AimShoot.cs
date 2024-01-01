using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimShoot : MonoBehaviour
{
    public GameObject Gun;

    private Animator animator;
    public AudioSource footstepsSound, sprintSound;
    private bool Holstered = false;

    void Start()
    {
        // Get the Animator component attached to the GameObject
        animator = GetComponent<Animator>();



    }

    void Update()
    {

     

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                footstepsSound.enabled = false;
                sprintSound.enabled = true;
            }
            else
            {
                footstepsSound.enabled = true;
                sprintSound.enabled = false;
            }
        }
        else
        {
            footstepsSound.enabled = false;
            sprintSound.enabled = false;
        }
  
      
        if (Input.GetMouseButton(1)) // 1 corresponds to the right mouse button
        {
            Gun.GetComponent<Animator>().Play("Aim");
        }
       else if (Input.GetKey(KeyCode.LeftShift))
        {
            Gun.GetComponent<Animator>().Play("Running");
        }

        else
        {
            Gun.GetComponent<Animator>().Play("Idle");
        }
      

    }

   
       
   
}