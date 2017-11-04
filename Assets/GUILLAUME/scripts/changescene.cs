using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changescene : MonoBehaviour {

public void OnStartGame() { 
        
        SceneManager.LoadScene("test1");

    }


    public void credit()
    {
        SceneManager.LoadScene("creditscene");

    }

    public void quit()
    {

        Application.Quit();

    }

}
