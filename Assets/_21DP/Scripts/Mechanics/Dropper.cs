using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    public GameObject[] dropList;

    public void Drop(Vector3 position)
    {
        int index = Random.Range(0, dropList.Length);

        GameObject drop = dropList[index];

        Instantiate(drop, position, Quaternion.identity);
    }
}
