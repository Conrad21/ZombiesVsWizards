using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject myPrefab;
 // private Vector3 gun = GameObject.Find("Gun");
   public GameObject player ;  
   Vector3 temp = new Vector3(7.0f,0,0);
    Vector3 ah; 
    // Start is called before the first frame update
    void Start()
    {
        ah = player.transform.position+ temp;
        Instantiate(myPrefab, ah,Quaternion.identity);
        Debug.Log("My buddy is now here");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
