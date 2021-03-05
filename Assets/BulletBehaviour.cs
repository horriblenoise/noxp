using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour {
    public float bulletSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
   Rigidbody ourRigidBody = GetComponent<Rigidbody>();
   ourRigidBody.velocity = transform.forward * bulletSpeed;
    }
}