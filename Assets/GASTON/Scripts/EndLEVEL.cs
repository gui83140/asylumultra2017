using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLEVEL : MonoBehaviour {

    public GameObject completeLevelUI;

	void OnTriggerEnter ()
    {
        completeLevelUI.SetActive(true);
    }

}
