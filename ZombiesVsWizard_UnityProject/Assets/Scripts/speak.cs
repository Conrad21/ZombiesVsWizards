using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speak : MonoBehaviour
{

    public GameObject T1;
    public GameObject T2;
    public static int text = 0;
    public static int frame = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public static int closed = 0;

    // Update is called once per frame
    void Update()
    {
        if (text == 1 && Input.GetKeyDown(KeyCode.C))
        {
            T1.SetActive(false);
            T2.SetActive(true);
            text = 2;
        }

        if (text == 0 && frame > 1200 )
        {
            T1.SetActive(true);
            text = 1;
           // frame = 1;
        }




        if (text == 2 && Input.GetKeyDown(KeyCode.C))
        {
            T2.SetActive(false);

        }

        if (text != 2)
        {
            frame++;
        }



    }
}
