using UnityEngine;
using System.Collections;

public class DoorScript : MonoBehaviour
{

    public static bool doorKey;
    public bool open;
    public bool inTrigger;
    private bool soundplayed;
    public GameObject Ca_Fe;
    public GameObject Ca_Ou;
    public AudioClip[] Clips;
    private AudioSource[] audioSources;
    private Animator _animator;

    void Start()
    {
        soundplayed = false;
        audioSources = new AudioSource[Clips.Length];
        int i = 0;
        while (i < Clips.Length)
        {
            GameObject child = new GameObject("Player");

            child.transform.parent = gameObject.transform;

            audioSources[i] = child.AddComponent<AudioSource>() as AudioSource;

            audioSources[i].clip = Clips[i];

            i++;
        }
        _animator = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        inTrigger = true;
    }

    void OnTriggerExit(Collider other)
    {
        inTrigger = false;
    }

    void Update()
    {
        if (inTrigger)
        {
            if (doorKey)
            {
                if (!soundplayed)
                {
                    open = true;
                    SoundFX();
                    Ca_Fe.SetActive(false);
                    Ca_Ou.SetActive(true);
                    _animator.SetBool("open", true);
                    soundplayed = true;
                }               
            }
        }
    }

    void SoundFX()
    {
        audioSources[0].Play();
        audioSources[1].Play();
    }
}
