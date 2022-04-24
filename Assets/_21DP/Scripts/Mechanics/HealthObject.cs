using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthObject : MonoBehaviour
{
    
    public enum Type { Damage, HealthPack }
    public Type myType;

    public float healthModifier = 25;


}
