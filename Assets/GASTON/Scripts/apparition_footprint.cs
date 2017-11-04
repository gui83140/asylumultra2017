using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apparition_footprint : MonoBehaviour {

    public GameObject empreinte;
    public GameObject FootMoove;
    public GameObject Socket;

    bool OnDown = false;

    void Update()
    {

        empreinte.SetActive(true);

        if (OnDown)
        {
            empreinte.SetActive(false);        
            OnDown = false;

            Instantiate(FootMoove, Socket.transform.position, Socket.transform.rotation);
        }
        if (Input.GetKey(KeyCode.Z))
        {
            OnDown = true;
        }
        if (Input.GetKey(KeyCode.S))
        {
            OnDown = true;
        }
        if (Input.GetKey(KeyCode.Q))
        {
            OnDown = true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            OnDown = true;
        }
    }

}