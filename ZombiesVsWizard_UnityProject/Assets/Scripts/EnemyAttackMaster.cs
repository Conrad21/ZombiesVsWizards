using UnityEngine;
using System.Collections;


public class EnemyAttackMaster : MonoBehaviour
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

    public GameObject myPrefab;
    public GameObject Master;

    Vector3 temp = new Vector3(3.0f,0,0);
    Vector3 temp2 = new Vector3(-3.0f,0,0);
    Vector3 ah; 
    public GameObject fireball;

    void Start ()
    {
        // Setting up the references.
        //player = GameObject.FindWithTag("MyPlayer");

         MaxHealth = 20f; 
        CurrentHealth = MaxHealth;
        player = GameObject.FindWithTag("MyPlayer");
      //  fireball = GameObject.FindWithTag("fireball");
        playerHealth = player.GetComponent <PlayerHealth> ();
      //  enemyHealth = GetComponent<EnemyHealth>();

    }

    // private void OnCollisionEnter(Collision collision)
    // {
       
    //     Debug.Log("You hit him");
    //     TakeDamage(6);
    //     //Destroy(gameObject); 
    // }



  private void OnCollisionEnter(Collision collision)
    {
       
       // Debug.Log("You hit him");
       // TakeDamage(6);
        //Destroy(gameObject); 
    }
    
    void OnTriggerEnter (Collider other)
    {
         //TakeDamage(6);
        // If the entering collider is the player...
        if(other.gameObject == player)
        {
            // ... the player is in range.
            playerInRange = true;
         
            Debug.Log("HAH");
           //  TakeDamage(6);
        }

        if(other.gameObject == fireball)
        {
            // ... the player is in range.
        
          Debug.Log("You hit him");
        TakeDamage(6);
            
           //  TakeDamage(6);
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
             fireball = GameObject.FindWithTag("fireball");
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

    private void Die(){
     
        Debug.Log("He Dead!"); 
        Destroy(gameObject); 
         Spawn1();
         Spawn2();
    }
  
    public void Spawn1(){
        ah = Master.transform.position+ temp;
        Instantiate(myPrefab, ah,Quaternion.identity);
        Debug.Log("My buddy is now here");
    }

    public void Spawn2(){
        ah = Master.transform.position+ temp2;
        Instantiate(myPrefab, ah,Quaternion.identity);
        Debug.Log("My buddy is now here");
    }
}