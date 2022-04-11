using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField]
    private string myName;
    [SerializeField]
    private string myClass;
    [SerializeField]
    private int level;

    public string GetName()
    {
        return myName; 
    }
    public string GetClass()
    {
        return myClass;
    }
    public int GetLevel()
    {
        return level;
    }
}
