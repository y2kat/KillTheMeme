using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float speed = 1f;
    public float frenquency = 1f;
    public float lenght = 1f;

    public enum PlatformType { Horizontal, Vertical, Circular }
    public PlatformType type;

    private Rigidbody rb;
    Vector3 target;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (type == PlatformType.Horizontal)
            transform.position = new Vector3(Mathf.Sin(Time.fixedTime * frenquency) * lenght, transform.position.y, transform.position.z);

        rb.MovePosition(target);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            PlatformAttacher attacher = other.gameObject.GetComponent<PlatformAttacher>();
            attacher.onPlatform = true;
            attacher.platformRigidbody = rb;
            attacher.rb.isKinematic = false;
            attacher.rb.useGravity = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<PlatformAttacher>().onPlatform = false;
        }
    }
}
