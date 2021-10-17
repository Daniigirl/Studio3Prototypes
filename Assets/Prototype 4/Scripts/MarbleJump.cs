using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleJump : MonoBehaviour
{ 
    private CharacterController controller;
    private float jumpSpeed = 10;
    private Rigidbody rigidBody;
    [SerializeField] private float jumpHeight;
    private bool onGround = true;
    private float verticalVelocity;
    private float gravity = 8.0f;
    private float jumpForce = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && onGround)
        {
            rigidBody.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
            onGround = false;
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        onGround = true;
    }
}
