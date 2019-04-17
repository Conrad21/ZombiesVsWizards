using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class necrosttack : MonoBehaviour
{

    /* Rigidbody rb;
    bool PlayerPresent = false, ZombiesPresent = false;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float distance;

        float angle = 0;
        for (int i = 0; i < 30; i++)
        {
            float x = Mathf.Sin(angle);
            //float y = Mathf.Cos(angle);
            angle += 10 * Mathf.PI;

            Vector3 dir = new Vector3(transform.position.x + angle, transform.position.y, 0);
            RaycastHit hit;
            Debug.DrawLine(transform.position, dir, Color.red);
            if (Physics.Raycast(transform.position, dir, out hit))
            {
                print(hit.collider.gameObject.name);
                if (hit.collider.gameObject.name.Equals("Player"))
                {
                    PlayerPresent = true;
                    distance = hit.distance;
                    print(hit.collider.gameObject.name); //wizard3?
                    float step = -2f * Time.deltaTime;
                    transform.position = Vector3.MoveTowards(transform.position, hit.collider.gameObject.transform.position, step);

                }
                if (hit.collider.gameObject.name.ToUpper().Contains("ZOMBIE"))
                {
                    ZombiesPresent = true;
                    if (PlayerPresent && ZombiesPresent)
                    {
                        float step = -2f * Time.deltaTime; 
                        // calculate distance to move
                        //move towards doesnt trigger
                        //hit.collider.gameObject.transform.position = Vector3.MoveTowards(hit.collider.gameObject.transform.position, transform.position, step);
                        transform.position = Vector3.MoveTowards(transform.position, hit.collider.gameObject.transform.position, step);
                    }
                }
            }
        }
    }*/
}

