using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlitchSystem : MonoBehaviour
{
    public float waitTime;
    public Image glitchImage;
    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        InvokeRepeating("ActiveGlitch", waitTime, waitTime);
    }

    private void ActiveGlitch()
    {
        glitchImage.enabled = true;
        animator.enabled = true;
    }

    public void TurnOff()
    {
        glitchImage.enabled = false;
        animator.enabled = false;
    }
}
