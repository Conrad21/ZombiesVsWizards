using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public AudioClip Dripmusic;
    public AudioSource dripSource;

    public int musicSounds = 1;

    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (dripSource.isPlaying == false && musicSounds == 1)
        {
            dripSource.PlayOneShot(Dripmusic);
        }

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (musicSounds == 1)
            {
                musicSounds = 0;
                dripSource.Stop();
            }
            else { musicSounds = 1; }
        }

    }
}

