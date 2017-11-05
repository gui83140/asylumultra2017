using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampeEtat : MonoBehaviour
{
    public static bool allum;
    public static bool ok;
    public Light Lampe;

	void Update () {

        if(ok)
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            Lampe.enabled = !Lampe.enabled;
            ok = false;
        }
        if(Lampe.enabled)
        {
            Enemy_Controller.allum = true;
        }
        if(!Lampe.enabled)
        {
            Enemy_Controller.allum = false;
        }
    }
}