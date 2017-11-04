using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pas_Follow1 : MonoBehaviour
{

    public GameObject player;

    private Vector3 offset;

    private Vector3 position;

    public Transform pas;

    private float timecount;

    void Start()
    {
        

        position = player.transform.position;

        timecount = 0;
    }

    void LateUpdate()
    {
        if (position != player.transform.position){

            timecount = timecount + 1 * Time.deltaTime;
            if ( timecount > 2 && position.magnitude < player.transform.position.magnitude+3|| position.magnitude > player.transform.position.magnitude + 3)
            {
                Instantiate(pas, player.transform.position  +offset, Quaternion.identity);
                position = player.transform.position;
                timecount = 0;
                transform.position = player.transform.position + offset;
            }

       // 
    }
        

       // if (position != player.transform.position && timecount>2)
        //{
            
          //  timecount = 0;
            //position = player.transform.position;
        //}
    }

}
