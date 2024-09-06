using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float spinSpeed = 1000.0f;  // Speed at which the propeller spins

    // Start is called before the first frame update
    void Start()
    {
        // Optional: Any initialization if needed
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the propeller around its local Z axis (forward axis)
        transform.Rotate(Vector3.forward * spinSpeed * Time.deltaTime);
    }
}
