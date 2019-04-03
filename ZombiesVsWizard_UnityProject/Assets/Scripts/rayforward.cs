using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rayforward : MonoBehaviour
{
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float distance;
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 15; //change 15 units to length of room for NPC2
        Debug.DrawRay(transform.position, forward, Color.cyan);
        if (Physics.Raycast(transform.position, forward, out RaycastHit hit))
        {
            if(hit.collider.gameObject.name.Equals("Player"))
            {
                distance = hit.distance;
                print(hit.collider.gameObject.name); //wizard3?
                float step = 1f * Time.deltaTime; // calculate distance to move
                transform.position = Vector3.MoveTowards(transform.position, hit.collider.gameObject.transform.position, step);
                //name is hit.collider.gameObject.name
            }
        }
    }
}
