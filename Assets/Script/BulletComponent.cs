using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletComponent : MonoBehaviour
{
    public float bulletSpeed = 10f; // Speed of the bullet

    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * bulletSpeed, ForceMode.Impulse);

        bulletSpeed = 10.0f;
        // Destroy the bullet after 5 seconds
        Destroy(gameObject, 5f);
    }
}
