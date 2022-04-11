using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSwitch : Interactable
{
    public GameObject item;
    
    public override void OnInteraction()
    {
        item.SetActive(true);
    }
}
