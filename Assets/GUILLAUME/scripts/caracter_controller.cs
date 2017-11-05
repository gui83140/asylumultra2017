using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caracter_controller : MonoBehaviour {
    float posX; float posY; public float walkspeed; public float runspeed; private bool dansleau; Vector3 position; float countime;

    private bool CanMove = true;

    // Use this for initialization
    void Start() {
        countime = 0f;
        
        dansleau = false;
        position = transform.position;
    }

    // Update is called once per frame
    void Update() {


        if (CanMove)
        {
            if (Input.GetButton("run"))
            {
                runspeed = 1.5f;
            }

            else { runspeed = 1; }


            posX = Input.GetAxis("Horizontal");
            posY = Input.GetAxis("Vertical");

            transform.position = transform.position + new Vector3(posX, 0, posY) * walkspeed * runspeed;


            if (dansleau == true && position != transform.position)
            {

                countime = countime + 1;


                if (countime == 25 && position != transform.position)
                {

                    GetComponent<AudioSource>().Play();

                    dansleau = false;
                    countime = 0;
                    position = transform.position;
                }
            }
        }     
    }
    //void OnCollisionStay(Collision collision)
    void OnTriggerStay(Collider theCollision)
    {
        if (theCollision.gameObject.tag == "EAU") {

            dansleau = true;

        }

    }

    void OnTriggerEnter(Collider theCollision)
        {
            if (theCollision.gameObject.tag == "EAU")
            {
                GetComponent<AudioSource>().Play();

                
            }

            if (theCollision.gameObject.tag == "ENDLVL")
            {
            CanMove = !CanMove;
            }

            if (theCollision.gameObject.tag == ("enemy"))
            {
            CanMove = !CanMove;
            }
        }
        
    private void OnTriggerExit(Collider thecollision)
    {
        dansleau = false;
        countime = 0;
        
    }
}


  

