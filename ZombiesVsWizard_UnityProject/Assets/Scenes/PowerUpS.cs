using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpS : MonoBehaviour
{
    public GameObject player ;   
    bool playerInRange; 
    Move Move; 

    // Start is called before the first frame update
    void Start()
    {
        playerInRange = false; 
        
        player = GameObject.FindWithTag("MyPlayer");
        Move = player.GetComponent <Move> ();
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
        
            // ... the player is no longer in range.
            playerInRange = true;
            Move.speedup();
                 Debug.Log("POOP"); 
            Destroy(gameObject);
         
        }
        else {
            playerInRange = false;
        }
    }
    
}
