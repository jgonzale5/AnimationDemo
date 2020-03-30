using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator animator;
    public CharacterController controller;
    public float backwardSpeed;
    public float forwardSpeed;
    public float sideSpeed;
    public KeyCode attackKey;

    // Update is called once per frame
    void Update()
    {
        float inputY = Input.GetAxis("Vertical");
        float inputX = Input.GetAxis("Horizontal");
        Vector3 movement = Vector3.zero;

        if (inputY > 0)
        {
            movement = new Vector3(inputX * sideSpeed, 0, inputY * forwardSpeed);
            controller.Move(movement * Time.deltaTime);
        }
        else
        {
            movement = new Vector3(inputX * sideSpeed, 0, inputY * backwardSpeed);
            controller.Move(movement * Time.deltaTime);
        }
        animator.SetFloat("SpeedY", inputY);
        animator.SetFloat("SpeedX", inputX);

        if (Input.GetKeyDown(attackKey))
        {
            animator.SetTrigger("Attack");
        }
    }
}
