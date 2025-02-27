using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float life= 3;

    void Awake()
    {
        Destroy (gameObject, life);

    }

    void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.CompareTag("Enemy")){
            Destroy(collision.gameObject);
        Destroy(gameObject);
        }
    }
}
