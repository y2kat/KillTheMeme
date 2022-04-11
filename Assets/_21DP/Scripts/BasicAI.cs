using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BasicAI : MonoBehaviour
{
    NavMeshAgent agent;
    Animator animator;
    Transform player;

    bool canMove = false;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        player = EnemyManager._player;
        StartCoroutine(EnableMovement());
    }

    void Update()
    {
        if (canMove)
           agent.SetDestination(player.position);

        if (agent.velocity == Vector3.zero)
            animator.SetInteger("State", 0);
        else
            animator.SetInteger("State", 1);
    }

    IEnumerator EnableMovement()
    {
        yield return new WaitForSeconds(3f);
        canMove = true;
    }
}
