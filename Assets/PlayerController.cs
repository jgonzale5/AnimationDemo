using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController controller;
    public Animator animator;
    public float forwardSpeed;
    public float backwardSpeed;
    public float strafeSpeed;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            animator.SetTrigger("Attack");
        }

        float inputX = Input.GetAxis("Horizontal");
        float inputZ = Input.GetAxis("Vertical");

        animator.SetFloat("X", inputX);
        animator.SetFloat("Z", inputZ);

        Vector3 movement;

        if (inputZ > 0)
        {
            movement = new Vector3(inputX * strafeSpeed * Time.deltaTime,
                0, inputZ * forwardSpeed * Time.deltaTime);
        }
        else
        {
            movement = new Vector3(inputX * strafeSpeed * Time.deltaTime,
                0, inputZ * backwardSpeed * Time.deltaTime);
        }

        controller.Move(movement);
    }
}
