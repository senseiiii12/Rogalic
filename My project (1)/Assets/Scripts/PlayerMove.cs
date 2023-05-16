using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public class PlayerMove : MonoBehaviour
{
    float horizontal;
    float vertical;
    Vector2 direction;
    Animator animator;
    new Rigidbody2D rigidbody2D;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");     
    } 
    private void FixedUpdate()
    {
        if (horizontal != 0 || vertical != 0)
        {
            AnimatorMovement(horizontal, vertical);
        }
        else
        {
            animator.SetLayerWeight(1, 0);
        }
        rigidbody2D.velocity = new Vector2(horizontal * PlayerStats.plStats.speed, vertical * PlayerStats.plStats.speed);
    }

    private void AnimatorMovement(float x, float y)
    {
        animator.SetLayerWeight(1, 1);
        animator.SetFloat("DirectionX", x);
        animator.SetFloat("DirectionY", y);
    }

    
}
