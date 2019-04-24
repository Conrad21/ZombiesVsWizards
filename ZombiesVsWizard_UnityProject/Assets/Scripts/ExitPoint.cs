using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitPoint : MonoBehaviour
{
    // Start is called before the first frame update
    bool playerInRange; 
    int ha; 
     public GameObject player ; 


    void Start ()
    {
        // Setting up the references.
        //player = GameObject.FindWithTag("MyPlayer");
        player = GameObject.FindWithTag("MyPlayer");
      //  enemyHealth = GetComponent<EnemyHealth>();

    }


void OnTriggerEnter (Collider other)
    {
        // If the entering collider is the player...
        if(other.gameObject == player)
        {
            // ... the player is in range.
            playerInRange = true;
            Debug.Log("HAH");

            SceneManager.LoadScene("Win Screen");
        }
    }

  void OnTriggerExit (Collider other)
    {
        // If the exiting collider is the player...
        if(other.gameObject == player)
        {
            // ... the player is no longer in range.
            playerInRange = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        Debug.Log("You Reached the exit");
        Destroy(gameObject); 
    }
}
