using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformAttacher : MonoBehaviour
{
    public bool onPlatform = false;
    public Rigidbody rb;
    public Rigidbody platformRigidbody;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (onPlatform)
            rb.velocity += new Vector3(platformRigidbody.velocity.x, 0, platformRigidbody.velocity.z);
    }
}
