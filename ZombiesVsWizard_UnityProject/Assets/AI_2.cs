using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_2 : MonoBehaviour
{
    Transform goal;
    UnityEngine.AI.NavMeshAgent agent;

    public GameObject FindClosestEnemy()
    {
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("necro");
        GameObject closest = null;
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;
        foreach (GameObject go in gos)
        {
            Vector3 diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                closest = go;
                distance = curDistance;
            }
        }
        return closest;
    }

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        goal = FindClosestEnemy().transform;
        agent.destination = new Vector3(goal.position.x, this.gameObject.transform.position.y, goal.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = new Vector3(goal.position.x, this.gameObject.transform.position.y, goal.position.z);//goal.position;
    }
}
