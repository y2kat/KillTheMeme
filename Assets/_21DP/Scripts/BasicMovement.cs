using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{

    public float speed = 1f;
    public float frequency = 1f;
    public float lenght = 1f;

    public enum PlatformType { Horizontal, Vertical, Circular }
    public PlatformType type;

    void Update()
    {
        if (type == PlatformType.Horizontal)
            transform.position = new Vector3(Mathf.Sin(Time.fixedTime * frequency) * lenght, transform.position.y, transform.position.z);

        else if (type == PlatformType.Vertical)
            transform.position = new Vector3(transform.position.x, Mathf.Sin(Time.fixedTime * frequency) * lenght, transform.position.z);

        else if (type == PlatformType.Circular)
            transform.position = new Vector3(Mathf.Sin(Time.fixedTime * frequency) * lenght, Mathf.Cos(Time.fixedTime * frequency) * lenght, transform.position.z);

        //transform.position = new Vector3(transform.position.x + step, transform.position.y, transform.position.z); 
        //transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y + step, transform.eulerAngles.z);
        //transform.localScale = new Vector3(transform.localScale.x + step, transform.localScale.y, transform.localScale.z);



    }
}
