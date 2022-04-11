using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    GameObject outlineMesh;

    private void Start()
    {
        outlineMesh = gameObject.transform.GetChild(0).gameObject;
    }

    public void OnLookingAt(bool state) 
    { 
        outlineMesh.SetActive(state);
    }

    public virtual void OnInteraction() { }
}
