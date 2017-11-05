using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Enemy_Controllernew : MonoBehaviour
{

    public static bool allum;
    public static float LookRadius = 5f;
    public float RestartDelay = 2f;
    public ParticleSystem blood;

    public Transform target;
    NavMeshAgent agent;

    // Use this for initialization
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {

        float distance = Vector3.Distance(target.position, transform.position);

        if (allum)
        {
            Enemy_Controller.LookRadius = 9f;
        }
        if (!allum)
        {
            Enemy_Controller.LookRadius = 5f;
        }
        if (distance <= LookRadius)
        {

            agent.SetDestination(target.position);

            if (distance <= agent.stoppingDistance)
            {
                FaceTarget();
            }
        }
    }

    void FaceTarget()
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

    void OnTriggerEnter(Collider bite)
    {
        if (bite.gameObject.tag == "Player")
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            blood.Play();
            Invoke("Restart", RestartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
