using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public GameObject player ;   
    bool playerInRange; 
   PlayerHealth playerHealth; 

    // Start is called before the first frame update
    void Start()
    {
        playerInRange = false; 
        
        player = GameObject.FindWithTag("MyPlayer");
        playerHealth = player.GetComponent <PlayerHealth> ();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        // If the exiting collider is the player...
        if(other.gameObject == player)
        {
             Debug.Log("POOP"); 
            // ... the player is no longer in range.
            playerInRange = true;
            playerHealth.addheal(100);
            Destroy(gameObject);
         
        }
        else {
            playerInRange = false;
        }
    }
    
}
