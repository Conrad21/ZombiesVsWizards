using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class die : MonoBehaviour
{
    public GameObject necro;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "fire")
        {
            Debug.Log("Collision detected");
            Destroy(necro);
        }
    }
}
