using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_Movement : MonoBehaviour
{
    private float speed;
    [SerializeField] private float walkSpeed = 7f;
    [SerializeField] private float runSpeed = 11f;
    [SerializeField] private float jHeight = 1.5f;
    [SerializeField] private CharacterController controller;

    [SerializeField] private float gravity = -27f;
    private Vector3 velocity;

    [SerializeField] private Transform groundCheck;
    [SerializeField] private float groundDistance = 0.4f;
    [SerializeField] private LayerMask groundMask;
    private bool isGrounded;


    
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    
    void Update()
    {
        // Sets a bool on whether or not the player is on the Ground layer.
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        // If the player is on the ground and y movement (aka jumping) is 0, it sets it to -2 to keep Gravity from continuously increasing
        if(isGrounded && velocity.y < 0) {
            velocity.y = -2;
        }

        // gets horizontal and vertical facing
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        //If space is pressed and you're on the ground, you jump jHeight
        if (Input.GetButtonDown("Jump") && isGrounded) {
            velocity.y = Mathf.Sqrt(-2 * jHeight * gravity);
        }

        Vector3 move = transform.right * x + transform.forward * z;

        // changes the speed depending if the player is walking or running
        if (Input.GetKey(KeyCode.LeftShift))
            speed = runSpeed;
        else
            speed = walkSpeed;

        controller.Move(move * speed * Time.deltaTime);

        //Sets gravity to increase the longer the Player is falling
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
        
    }
}
