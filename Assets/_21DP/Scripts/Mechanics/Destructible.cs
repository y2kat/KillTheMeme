using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour
{
    float resitance = 100;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Projectile")
        {
            TakeDamage(collision.gameObject.GetComponent<Projectile>().GetDamageAmount());
        }          
    }

    void TakeDamage(float damage)
    {
        resitance -= damage;

        MemeManager.EnableMeme();

        if (resitance <= 0)
        {
            GetComponent<Dropper>().Drop(transform.position);
            Destroy(gameObject);
        }         
    }
}
