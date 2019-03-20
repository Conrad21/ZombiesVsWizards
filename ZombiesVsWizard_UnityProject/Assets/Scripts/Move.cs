using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// The GameObject is made to bounce using the space key.
// Also the GameOject can be moved forward/backward and left/right.
// Add a Quad to the scene so this GameObject can collider with a floor.
//Taken From the Unity Manual Website

public class Move : MonoBehaviour
{
    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    public float rotationSpeed = 40;
    private Vector3 moveDirection = Vector3.zero;
    private CharacterController controller;
    Transform t;
    void Start()
    {
        controller = GetComponent<CharacterController>();
        t = GetComponent<Transform>();
        // let the gameObject fall down
        //gameObject.transform.position = new Vector3(14.57, 2.43, 13.47);
    }

    void Update()
    {
        if (controller.isGrounded)
        {
            // We are grounded, so recalculate
            // move direction directly from axes

            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection = moveDirection * speed;

            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }
        if (Input.GetKey(KeyCode.E))
                t.rotation *= Quaternion.Euler(0, rotationSpeed * Time.deltaTime, 0);
            else if (Input.GetKey(KeyCode.Q))
                t.rotation *= Quaternion.Euler(0, -rotationSpeed * Time.deltaTime, 0);

        // Apply gravity
        moveDirection.y = moveDirection.y - (gravity * Time.deltaTime);

        // Move the controller
        controller.Move(moveDirection * Time.deltaTime);
    }
}