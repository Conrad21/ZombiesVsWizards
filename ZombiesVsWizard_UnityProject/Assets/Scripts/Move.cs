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

    public AudioClip Dripmusic;
    public AudioSource dripSource;
    public int musicSounds = 1;

    public GameObject bullet;
    public GameObject cannon;


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

        if (dripSource.isPlaying == false && musicSounds == 1)
        {
            dripSource.PlayOneShot(Dripmusic);
        }

        if (Input.GetKeyDown(KeyCode.Mouse0)) {       
            GameObject newBullet = GameObject.Instantiate(bullet, cannon.transform.position, cannon.transform.rotation) as GameObject;
            newBullet.GetComponent<Rigidbody>().velocity += Vector3.up * 5;
            newBullet.GetComponent<Rigidbody>().AddForce(newBullet.transform.forward * 1000);
        }

        if (Input.GetKeyDown(KeyCode.Tab))
            if (musicSounds == 1)
            {
                musicSounds = 0;
                dripSource.Stop();
            }
            else { musicSounds = 1; }
    }
}