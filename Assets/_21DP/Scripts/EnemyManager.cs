using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public Transform player;
    public static Transform _player;

    public int availableEnemies;
    public static int _availableEnemies;

    private void Start()
    {
        _player = player;
        _availableEnemies = availableEnemies;
    }
}
