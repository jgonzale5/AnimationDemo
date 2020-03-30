using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteController : MonoBehaviour
{
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        float input = Input.GetAxis("Horizontal");
        animator.SetFloat("InputX", input);
    }
}
