using UnityEngine;
using System.Collections;

public class DoorScriptOUV : MonoBehaviour
{

    public static bool doorKey;
    public bool open;
    public bool inTrigger;
    private bool soundplayed;
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
        if (!soundplayed)
        {
            open = true;
            SoundFX();
            _animator.SetBool("open", true);
            soundplayed = true;
        }
    }

    void Update()
    {

    }

    void SoundFX()
    {
        audioSources[0].Play();
        audioSources[1].Play();
    }
}
