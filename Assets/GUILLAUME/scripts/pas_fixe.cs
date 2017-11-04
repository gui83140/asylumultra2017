using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pas_fixe : MonoBehaviour {

    private bool bouge; Vector3  position;
       
	// Use this for initialization
	void Start () {

        bouge = false;
        position =  transform.position ;
	}
	
	// Update is called once per frame
	void Update () {

        if (position != transform.position)
        {
            

        }
		
	}
}
