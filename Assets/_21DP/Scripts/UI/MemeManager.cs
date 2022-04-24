using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemeManager : MonoBehaviour
{
    [SerializeField]
    public GameObject meme;
    public float duration;

    public static GameObject _meme;

    static bool isActive = true;

    private void Start()
    {
        _meme = meme;
    }

    private void Update()
    {
        if (isActive)
        {
            isActive = false;
            StartCoroutine(CoolDown());
        }
           
    }

    public static void EnableMeme()
    {
        if (!isActive)
        {
            _meme.SetActive(true);
            isActive = true;
        }        
    }

    IEnumerator CoolDown()
    {
        yield return new WaitForSeconds(duration);
        _meme.SetActive(false);
    }
}
