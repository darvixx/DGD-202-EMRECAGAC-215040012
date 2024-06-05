using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CarReset : MonoBehaviour
{
    // The start position of the car
    private Vector3 startPosition;
    private Quaternion startRotation;

    void Start()
    {
        // Save the initial position and rotation of the car
        startPosition = transform.position;
        startRotation = transform.rotation;
    }

    void Update()
    {
        // Check if the 'R' key is pressed
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetPosition();
        }
    }

    // Method to reset the car's position
    void ResetPosition()
    {
        transform.position = startPosition;
        transform.rotation = startRotation;

        // Optionally, reset the car's velocity if it has a Rigidbody component
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }
}
