using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private static List<Item> inventory;

    private void Start()
    {
        inventory = new List<Item>();
    }

    public static void SaveItem(Item item)
    {
        inventory.Add(item);
        Debug.Log("Saving item");
    }

    public static bool HasKey(int index)
    {
        foreach(var item in inventory)
        {
            Key key = item as Key;
            if(key != null)
            {
                if (key.ID == index)
                    return true;
            }
        }

        return false;
    }
}
