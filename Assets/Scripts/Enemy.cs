using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public Transform player;
    public float patrolRadius = 20f;
    public float chaseRadius = 10f;
    public float loseRadius = 15f;
    public float waitTime = 2f;

    public float enemyHealth = 20;

    private NavMeshAgent agent;
    private Vector3 patrolPoint;
    private bool playerInChaseRange;
    private bool playerInLoseRange;
    private float waitTimer;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        SetRandomPatrolPoint();
    }

    void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        playerInChaseRange = distanceToPlayer <= chaseRadius;
        playerInLoseRange = distanceToPlayer <= loseRadius;

        if (playerInChaseRange)
        {
            ChasePlayer();
        }
        else if (playerInLoseRange)
        {
            Patrol();
        }
        else
        {
            Patrol();
        }
    }

    void Patrol()
    {
        if (agent.remainingDistance <= agent.stoppingDistance)
        {
            waitTimer += Time.deltaTime;

            if (waitTimer >= waitTime)
            {
                SetRandomPatrolPoint();
                waitTimer = 0f;
            }
        }
    }

    void ChasePlayer()
    {
        agent.SetDestination(player.position);
    }

    void SetRandomPatrolPoint()
    {
        Vector3 randomDirection = Random.insideUnitSphere * patrolRadius;
        randomDirection += transform.position;
        NavMeshHit hit;
        NavMesh.SamplePosition(randomDirection, out hit, patrolRadius, 1);
        patrolPoint = hit.position;
        agent.SetDestination(patrolPoint);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, patrolRadius);
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, chaseRadius);
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, loseRadius);
    }


}
