using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleController : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed = 10f;
    private float xInput;
    private float zInput;
    private float boostTimer;
    private bool boosting;

    // Start is called before the first frame update
    void Start()
    {
        boostTimer = 0;
        boosting = false;
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInputs();

        if (boosting)
        {
            boostTimer += Time.deltaTime;
            if(boostTimer >= 3)
            {
                moveSpeed = 8000;
                boostTimer = 0;
                boosting = false;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "SpeedBoost")
        {
            boosting = true;
            moveSpeed = 16000;
        }
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void ProcessInputs()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");
    }

    private void Move()
    {
        rb.AddForce(new Vector3(xInput, 0f, zInput) * moveSpeed);
    }
}
