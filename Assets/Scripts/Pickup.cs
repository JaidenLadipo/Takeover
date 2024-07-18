using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public float rotationSpeed=5;
    public AudioSource soundPlayer;
    public AudioClip pickupSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter(Collider collisionObject)
    {
        if(collisionObject.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.UpdateScore(1);
            soundPlayer.PlayOneShot(pickupSound);
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(45,0,0)*rotationSpeed*Time.deltaTime);
    }
}

