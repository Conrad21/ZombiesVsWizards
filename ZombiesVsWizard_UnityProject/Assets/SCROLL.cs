using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SCROLL : MonoBehaviour
{
    public AudioClip Sound;
    public AudioSource Source;

    public static int player = 1;


    // Update is called once per frame
    void Update()
    {
        if (Source.isPlaying == false && player == 1)
        {
            Source.PlayOneShot(Sound);
        }

        if (Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

    }
}
