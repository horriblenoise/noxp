using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{

    public float bulletSpeed;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody ourRigidBody = GetComponent<Rigidbody>();
        ourRigidBody.velocity = transform.forward * bulletSpeed;
    }

    // Update is called once per frame
    void Update()
    {
    }

    new private void OnCollisionEnter(Collision thisCollision)
    {

        if (thisCollision.gameObject.GetComponent<EnemyBehaviour>() != null)
        {
            Destroy(thisCollision.gameObject);
            Destroy(gameObject);
        }
    }

  
}