using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_1 : MonoBehaviour
{
        public Transform goal;
        UnityEngine.AI.NavMeshAgent agent;

        void Start () 
        {
            agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
            agent.destination = new Vector3(goal.position.x,this.gameObject.transform.position.y,goal.position.z); 
        }

        void Update()
        {
            agent.destination = new Vector3(goal.position.x, this.gameObject.transform.position.y, goal.position.z);//goal.position;
        }
}
