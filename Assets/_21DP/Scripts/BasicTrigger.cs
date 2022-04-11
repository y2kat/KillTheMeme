using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
    }
}
