using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPShooter : MonoBehaviour
{
    public GameObject projectile;
    public Transform spawnPoint;
    AudioSource m_shootingSound;

    void Start()
    {
        m_shootingSound = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            GameObject instance = Instantiate(projectile, spawnPoint.position, Quaternion.identity);
            instance.transform.localEulerAngles = transform.eulerAngles;
            m_shootingSound.Play();
        }

    }
}
