using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth: MonoBehaviour
{
    public int tacos; 
    public float CurrentHealth;
    public float MaxHealth;
    public Slider healthbar; 
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
             TakeDamage(6.0f);
             CurrentHealth = (CurrentHealth - 6);
        }
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

    }
}
