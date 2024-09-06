using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(20, 5, 0);  // Adjusted to be beside the plane

    // Update is called once per frame
    void Update()
    {
        // Position the camera beside the plane
        transform.position = plane.transform.position + offset;

        // Make the camera look at the plane
        transform.LookAt(plane.transform);
    }
}
