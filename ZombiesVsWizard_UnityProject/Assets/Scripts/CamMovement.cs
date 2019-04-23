using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{

    Vector2 mouseLook; 
    Vector2 smoothV;
    public float sensitivity = 5.0f;
    public float smoothing = 2.0f; 
    GameObject character; 

    // Start is called before the first frame update
    void Start()
    {
       // character = this.tranform.partent.GameObject; 
    }

    // Update is called once per frame
    void Update()
    {
        // var md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
        // md = Vector2.Scale(md, new Vector2(sensitivity * smoothing, sensitivity*smoothing));
        // SmoothV.x = Mathf.Lerp(smoothV.x, md.x, 1f / smoothing);
        // SmoothV.x = Mathf.Lerp(smoothV.y, md.y, 1f / smoothing);
        // mouseLook += smoothV

        // tranform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
        // character.tranform.localRotation = Quaternion.AngleAxis(mouseLook.x, character.tranform.up);

    }
}
