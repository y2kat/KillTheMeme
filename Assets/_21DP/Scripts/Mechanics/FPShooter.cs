using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPShooter : MonoBehaviour
{
    public GameObject projectile;
    public Transform spawnPoint;


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject instance = Instantiate(projectile, spawnPoint.position, Quaternion.identity);
            instance.transform.localEulerAngles = transform.eulerAngles;
        }

    }
}
