using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pas_follow : MonoBehaviour {
        public GameObject target;
       
        private Vector3 offset; 

	// Use this for initialization
	void Start () {
        offset = new Vector3(0, 1, 0);
	}
	
	// Update is called once per frame
	void Update () {
        //targetedposition = new Vector3(target.transform.position.x, target.transform.position.y, target.transform.position.z);

        transform.position =  target.transform.position + offset;
    }
}
