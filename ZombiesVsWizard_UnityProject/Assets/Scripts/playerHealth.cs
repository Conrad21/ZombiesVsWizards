using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth: MonoBehaviour
{
    public int tacos; 
    public float CurrentHealth {get; set; }
    public float MaxHealth {get; set;}
    public Slider healthbar; 
    public Color flashColour = new Color(1f, 0f, 0f, 0.1f);
    public float flashSpeed = 5f;  
    bool isDead;                                             
    bool damaged;       


    
    // Start is called before the first frame update
    void Start()
    {
        MaxHealth = 20f; 
        CurrentHealth = MaxHealth;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.P)){
             TakeDamage(6);
             CurrentHealth = (CurrentHealth - 6);
        }

        //  if(damaged)
        // {
        //     // ... set the colour of the damageImage to the flash colour.
        //     //damageImage.color = flashColour;
        // }
        // else
        // {
        //     // ... transition the colour back to clear.
        //   //  damageImage.color = Color.Lerp (damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
        // }

        // damaged = false;
    }
    public void TakeDamage(float damageValue){
        damaged = true;
        CurrentHealth = (CurrentHealth - damageValue); 
        healthbar.value = CalculateHealth(); 
        
        if(CurrentHealth <= 0){
        Die();
        }
    }
    float CalculateHealth(){
        return CurrentHealth/MaxHealth ; 
    }


    void Die(){
        CurrentHealth = 0;
        Debug.Log("You have Dead!"); 
        SceneManager.LoadScene( 2);
    }
}
