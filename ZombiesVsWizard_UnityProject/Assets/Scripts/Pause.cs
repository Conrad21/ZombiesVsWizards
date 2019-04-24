using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
   public GameObject pauseMenuUI;
   private bool isPaused; 


    // Update is called once per frame
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            isPaused = !isPaused;
        }
        if(isPaused){
            ActiveMenu();
            Time.timeScale = 0; 
        }

        else{
            DeactiveMenu(); 
            Time.timeScale = 1; 
        }
    }

    void ActiveMenu(){
        pauseMenuUI.SetActive(true); 
    }

    void DeactiveMenu(){
        pauseMenuUI.SetActive(false); 
    }
}
