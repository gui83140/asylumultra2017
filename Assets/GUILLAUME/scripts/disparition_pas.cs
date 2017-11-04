using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparition_pas : MonoBehaviour
{
    float countime; float desinte;
    // Use this for initialization


    void Start()
    {
        countime = 0f;
        desinte = 100f;

    }

    // Update is called once per frame
    void Update()
    {
        //countime = countime*Time.deltaTime;
        //desinte = desinte - countime*10;
        //this.gameObject.GetComponent<SpriteRenderer>().color = new Color(255f, 255f, 255f, desinte);
        //  if (countime > 1)
        //{
        //  this.gameObject.GetComponent<SpriteRenderer>().color = new Color(255f, 255f, 255f, .8f);


        //        }

        /* if (countime > 1)
         {
             this.gameObject.GetComponent<SpriteRenderer>().color = new Color(255f, 255f, 255f, .60f);


         }

         if (countime > 2)
         {
             this.gameObject.GetComponent<SpriteRenderer>().color = new Color(255f, 255f, 255f, .40f);

         }
         if (countime > 3)
         {
             this.gameObject.GetComponent<SpriteRenderer>().color = new Color(255f, 255f, 255f,.0f);

         }*/
    }
}