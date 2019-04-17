using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_1 : MonoBehaviour
{
    /*public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float distance;
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 1000; 
        
        if (Physics.Raycast(transform.position, forward, out RaycastHit hit))
        {
            if(hit.collider.gameObject.name.Equals("Player"))
            {
                distance = hit.distance;
                
                float step = 10f * Time.deltaTime; 
                transform.position = Vector3.MoveTowards(transform.position, hit.collider.gameObject.transform.position, step);
                //name is hit.collider.gameObject.name
            }
        }
    }*/
       public Transform goal;
       
       void Start () 
       {
          UnityEngine.AI.NavMeshAgent agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
          agent.destination = goal.position; 
       }
}
