using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform target;
    public AudioSource soundPlayer;
    public AudioClip deathSound;
    // Start is called before the first frame update
    void Start()
    {
       agent=GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (target !=null)
        {
            agent.SetDestination(target.position);
        }

    }
    void OnTriggerEnter(Collider collisionObject)
    {
        if (collisionObject.gameObject.CompareTag("Player"))
        {
            soundPlayer.PlayOneShot(deathSound);
           
            GameManager.Instance.Invoke("GameOver",0.1f);
        }
    }
}
