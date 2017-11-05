using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Enemy_Controller : MonoBehaviour {

    public static bool allum;
    public static float LookRadius = 5f;
    public float RestartDelay = 2f;
    public ParticleSystem blood;
    private bool soundplayed;
    public Light cul;
    public AudioClip[] Clips;
    private AudioSource[] audioSources;
    public Transform target;
    private Vector3 posi;

    NavMeshAgent agent;

	// Use this for initialization
	void Start ()
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
        agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {

        float distance = Vector3.Distance(target.position, transform.position);
        
        if (allum)
        {
            Enemy_Controller.LookRadius = 9f;
        }
        if(!allum)
        {
            Enemy_Controller.LookRadius = 5f;
        }
        if (distance <= LookRadius)
        {
            cul.enabled = true;
            if (!soundplayed)
            {
                audioSources[1].Play();
                soundplayed = true;
            }
            
            agent.SetDestination(target.position);

            if (distance <= agent.stoppingDistance)
            {
                FaceTarget();
            }
        }
        if (distance >= LookRadius)
        {
            cul.enabled = false;
            soundplayed = false;
        }
	}

    void FaceTarget ()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion LookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, LookRotation, Time.deltaTime * 5f);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, LookRadius);
    }

    void OnTriggerEnter (Collider bite)
    {
        if(bite.gameObject.tag == "Player")
        {
            audioSources[0].Play();
            blood.Play();
            Invoke("Restart", RestartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
