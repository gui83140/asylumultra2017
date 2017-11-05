using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changescene : MonoBehaviour {

public void OnStartGame() { 
        
        SceneManager.LoadScene("tests_NIVEAUX 1");

    }


    public void credit()
    {
        SceneManager.LoadScene("creditscene");

    }

    public void retourmenu()
    {
        SceneManager.LoadScene("test_menu");

    }


    public void quit()
    {

        Application.Quit();

    }

}
