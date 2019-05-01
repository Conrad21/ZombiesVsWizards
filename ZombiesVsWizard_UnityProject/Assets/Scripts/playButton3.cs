using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playButton3 : MonoBehaviour
{
    public AudioClip Sound;
    public AudioSource Source;

    public AudioClip WhooshSound;
    public AudioSource WhooshSource;

    public static int player = 1;

    public void ButtonPress()
    {
        player = 0;
        Source.Stop();
            //WhooshSource.PlayOneShot(Sound);



        SceneManager.LoadScene("End Credits");
       
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Source.isPlaying == false && player == 1)
        {
            Source.PlayOneShot(Sound);
        }

        if (WhooshSource.isPlaying == false && player == 0)
        {
            WhooshSource.PlayOneShot(WhooshSound);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("rolling credits");

        }

         
    }
}
