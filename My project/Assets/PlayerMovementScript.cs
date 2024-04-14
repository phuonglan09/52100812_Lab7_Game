using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    public Animator animator;
    public AnimatorIDScript animatorIDScript;

    void Start()
    {
        animator = GetComponent<Animator>();
        animatorIDScript = GameObject.FindGameObjectWithTag("GameController").GetComponent<AnimatorIDScript>();
    }

    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        animator.SetFloat(animatorIDScript.speedID, verticalInput);

        if (verticalInput == 0)
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            if (horizontalInput > 0)
            {
                // Play TurnOnSpotRightA animation
                animator.Play("TurnOnSpotRightA");
            }
            else if (horizontalInput < 0)
            {
                // Play TurnOnSpotLeftA animation
                animator.Play("TurnOnSpotLeftA");
            }
        }
    }
}
