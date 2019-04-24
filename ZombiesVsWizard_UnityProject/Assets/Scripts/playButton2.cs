using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playButton2 : MonoBehaviour
{

    public static int player = 1;

    public void ButtonPress()
    {
    
      
            //WhooshSource.PlayOneShot(Sound);

        SceneManager.LoadScene("Win Screen");
       
    
    }

    // Update is called once per frame
    void Update()
    {


    }
}
