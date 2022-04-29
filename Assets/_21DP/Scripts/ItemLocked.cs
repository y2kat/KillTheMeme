using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemLocked : Interactable
{
    [SerializeField]
    private int necesaryItems = 3;

    public override void OnInteraction()
    {
        Debug.Log("Trying to access...");

        if (Inventory.HasItems(necesaryItems))
            OpenLock();
        else
            Debug.Log("Can not access...");
    }

    void OpenLock()
    {
        Debug.Log("Open");
        GetComponent<Animator>().enabled = true;
    }
}
