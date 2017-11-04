using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apparition_footprint : MonoBehaviour {

    public GameObject empreinte;
    public GameObject FootMoove;
    public GameObject FootMoove2;
    public GameObject Socket;

    private float InstantiationTimer = .5f;
    bool OnDown = false;
    bool AutrePied = true;

    void Update()
    {

        empreinte.SetActive(true);

        if (OnDown)
        {
            empreinte.SetActive(false);        
            OnDown = false;

            CreatePrefab();

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

    void CreatePrefab()
    {
        InstantiationTimer -= Time.deltaTime;
        if (InstantiationTimer <= 0 && AutrePied)
        {
            var Prints = Instantiate(FootMoove, Socket.transform.position, Socket.transform.rotation);
            InstantiationTimer = .5f;
            Destroy(Prints, 2f);
            AutrePied = false;
        }
        if (InstantiationTimer <= 0 && !AutrePied)
        {
            var Prints = Instantiate(FootMoove2, Socket.transform.position, Socket.transform.rotation);
            InstantiationTimer = .5f;
            Destroy(Prints, 2f);
            AutrePied = true;
        }
    }
}