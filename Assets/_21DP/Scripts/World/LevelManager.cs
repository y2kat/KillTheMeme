using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject objectPool;
    private static Transform pool;

    private void Start()
    {
        pool = objectPool.transform;
    }

    public static void SendToPool(GameObject objectToPool)
    {
        objectToPool.transform.SetParent(pool);
    }
}
