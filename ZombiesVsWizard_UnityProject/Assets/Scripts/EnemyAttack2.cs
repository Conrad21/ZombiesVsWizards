﻿using UnityEngine;
using System.Collections;


public class EnemyAttack2 : MonoBehaviour
{
    public float timeBetweenAttacks = 0.5f;     // The time in seconds between each attack.
    public float attackDamage = 10.0f;               // The amount of health taken away per attack.
    public float CurrentHealth;
    public float MaxHealth;
    bool isDead;                                             
    bool damaged;    

    public GameObject player ;                          // Reference to the player GameObject.
    PlayerHealth playerHealth;                  // Reference to the player's health.
   // EnemyHealth enemyHealth;                    // Reference to this enemy's health.
    bool playerInRange;                         // Whether player is within the trigger collider and can be attacked.
    float timer;                                // Timer for counting up to the next attack.


    void Start ()
    {
        // Setting up the references.
        //player = GameObject.FindWithTag("MyPlayer");

         MaxHealth = 20f; 
        CurrentHealth = MaxHealth;
        player = GameObject.FindWithTag("MyPlayer");
        playerHealth = player.GetComponent <PlayerHealth> ();
      //  enemyHealth = GetComponent<EnemyHealth>();

    }

    private void OnCollisionEnter(Collision collision)
    {
       
        Debug.Log("You hit him");
        TakeDamage(6);
        //Destroy(gameObject); 
    }

    void OnTriggerEnter (Collider other)
    {
        // If the entering collider is the player...
        if(other.gameObject == player)
        {
            // ... the player is in range.
            playerInRange = true;
            Debug.Log("HAH");
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


    void Update ()
    {
        // Add the time since Update was last called to the timer.
        timer += Time.deltaTime;

        // If the timer exceeds the time between attacks, the player is in range and this enemy is alive...
        if(timer >= timeBetweenAttacks && playerInRange )
        {
            // ... attack.
            Attack ();
        }

        // If the player has zero or less health...
        
    }


    void Attack ()
    {
        // Reset the timer.
        timer = 0f;

        // If the player has health to lose...
        if(playerHealth.CurrentHealth > 0)
        {
            // ... damage the player.
            playerHealth.TakeDamage (attackDamage);
        }
    }

public void TakeDamage(float damageValue){
        damaged = true;
        CurrentHealth = (CurrentHealth - damageValue); 
        if(CurrentHealth <= 0){
        Die();
        }
    }

    void Die(){
        CurrentHealth = 0;
        Debug.Log("He Dead!"); 
        Destroy(gameObject); 
    }
  

}