using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caracter_controller1 : MonoBehaviour {

    float posX; float posY; public float walkspeed; public float runspeed;

    // Use this for initialization
    void Start() {
        runspeed = 1;
    }

    // Update is called once per frame
    void Update() {

        if (Input.GetButton("run"))
        {
            runspeed = 1.4f;
        }

        else { runspeed = 1; }
        

        posX = Input.GetAxis("Horizontal");
        posY = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(posX, 0, posY) * walkspeed * runspeed;
        
    }    
}
