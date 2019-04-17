using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayersHealth : MonoBehaviour
{
    public int tacos; 
    public float CurrentHealth {get; set; }
    public float MaxHealth {get; set;}
    public Slider healthbar; 

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
             DealDamage(6);
             CurrentHealth = (CurrentHealth - 6);
        }
        
    }
    void DealDamage(float damageValue){
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
