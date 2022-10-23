using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 4f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        rb.AddForce(Vector3.up * speed * Time.deltaTime, ForceMode.Impulse);
    }
}
