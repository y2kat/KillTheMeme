using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            GetComponent<Light>().enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            GetComponent<Light>().enabled = true;
        }
    }
}
