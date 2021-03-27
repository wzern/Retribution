using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Player move speed
    public float moveSpeed = 5f;

    //Editing RigidBody2D
    public Rigidbody2D rb;

    //Editing Animator on player
    public Animator animator;

    //Storing player input for fixed update movement
    Vector2 movement;

    //Getting Camera 
    Vector2 mousePos;
    public Camera cam;

    void Update()
    {
        //Input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        //getting mouse position
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

    }

    private void FixedUpdate()
    {
        //Movement

        //Gets currect position then adds movement times move speed
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);


    }
}
