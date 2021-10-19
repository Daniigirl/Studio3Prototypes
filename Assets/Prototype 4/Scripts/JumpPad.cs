using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    [Range(100, 100000)]
    public float bounceHeight;

    private void OnCollisionEnter(Collision collision)
    {
        GameObject bouncer = collision.gameObject;
        Rigidbody rb = bouncer.GetComponent<Rigidbody>();
        rb.AddForce(Vector3.up * bounceHeight);
    }

}
