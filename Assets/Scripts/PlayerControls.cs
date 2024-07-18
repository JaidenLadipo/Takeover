using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    // Start is called before the first frame update
    public float movementSpeed=5;
    public CharacterController controller;
    void Start()
    {
        controller=GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput= Input.GetAxis("Horizontal");
        float verticalInput= Input.GetAxis("Vertical");

        Vector3 movement =new Vector3 (horizontalInput,0,verticalInput);

        movement = transform.TransformDirection (movement);


        movement*=movementSpeed;

        controller.Move(movement*Time.deltaTime);
    }
}
