using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;
    [SerializeField]
    private float damageAmount;

    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * speed; 
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
    public float GetDamageAmount() { return damageAmount; }
}
