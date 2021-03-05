﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerBehaviour2 : MonoBehaviour {
    public float speed;
    public GameObject bulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(speed);
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 inputVector = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Rigidbody ourRigidBody = GetComponent<Rigidbody>();
        ourRigidBody.velocity = inputVector * speed;
       
        Vector3 LookAtPosition = transform.position + inputVector;
        transform.LookAt(LookAtPosition);

       if (Input.GetButton("Fire1"))
       {
           Instantiate(bulletPrefab, transform.position + transform.forward, transform.rotation);
       }
    }
}
