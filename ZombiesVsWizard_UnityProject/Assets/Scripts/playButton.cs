using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playButton : MonoBehaviour
{
    public AudioClip Sound;
    public AudioSource Source;

    public AudioClip WhooshSound;
    public AudioSource WhooshSource;

    public void ButtonPress()
    {

        WhooshSource.PlayOneShot(Sound);

        if (WhooshSource.isPlaying == false)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Source.isPlaying == false)
        {
            Source.PlayOneShot(Sound);
        }


    }
}
