using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireSounds : MonoBehaviour
{
    public AudioClip Dripmusic;
    public AudioSource dripSource;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (dripSource.isPlaying == false)
        {
            dripSource.PlayOneShot(Dripmusic);
        }
    }
}
