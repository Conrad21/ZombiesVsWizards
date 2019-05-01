using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerHealth: MonoBehaviour
{
    public int tacos; 
    public float CurrentHealth;
    public float MaxHealth;
    public Slider healthbar; 
    bool isDead;                                             
    bool damaged;       
    public Color flashColour = new Color(5f, 0f, 0f, 0.3f);
    public float flashSpeed = 5f;  
    public Image DamangedImage; 

    // Start is called before the first frame update
    void Start()
    {
        MaxHealth = 100f; 
        CurrentHealth = MaxHealth;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.P)){
             TakeDamage(6.0f);
            // CurrentHealth = (CurrentHealth);
        }

        if(damaged)
        {
            // ... set the colour of the damageImage to the flash colour.
            DamangedImage.color = flashColour;
        }
        // Otherwise...
        else
        {
            // ... transition the colour back to clear.
            DamangedImage.color = Color.Lerp (DamangedImage.color, Color.clear, flashSpeed * Time.deltaTime);
        }

        // Reset the damaged flag.
        damaged = false;

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
        SceneManager.LoadScene("End Screen");
    }
    
    
   public void addheal(int n){
        CurrentHealth = 100; 
         healthbar.value = CalculateHealth(); 
    }
}
