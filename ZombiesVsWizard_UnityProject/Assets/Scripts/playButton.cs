using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playButton : MonoBehaviour
{
    public AudioClip Sound;
    public AudioSource Source;

    public AudioClip Sound2;
    public AudioSource Source2;

    public AudioClip WhooshSound;
    public AudioSource WhooshSource;

    public static int player = 1;

    public void ButtonPress()
    {
        player = 0;
        Source.Stop();
        WhooshSource.PlayOneShot(WhooshSound);
        //WhooshSource.PlayOneShot(Sound);



        SceneManager.LoadScene("Wizards Vs Zombies");
       
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Source.isPlaying == false && player == 1)
        {
            Source.PlayOneShot(Sound);
            player = 2;
        }

        if (Source.isPlaying == false && player == 2)
        {
            Source2.PlayOneShot(Sound2);
          
        }

        if (WhooshSource.isPlaying == false && player == 0)
        {
            WhooshSource.PlayOneShot(WhooshSound);
        }

    }
}
