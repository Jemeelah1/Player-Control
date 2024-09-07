using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Private Variables
    public float speed = 5.0f;
    public float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Get the player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Move the vehicle forward
        rb.AddForce(Vector3.forward * speed * forwardInput);

        // Turn the vehicle
        rb.AddTorque(Vector3.up * turnSpeed * horizontalInput);
    }
}
