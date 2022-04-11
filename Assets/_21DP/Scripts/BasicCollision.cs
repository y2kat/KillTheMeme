using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log(collision.gameObject.name);
        collision.gameObject.transform.localScale *= 2;
    }
}
