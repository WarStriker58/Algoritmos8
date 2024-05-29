using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFieldOfVision : MonoBehaviour
{
    /*public Transform[] waypoints;
    public float speed = 2f;
    public float energy = 100f;
    public float restTime = 3f;
    public float detectionRadius = 5f;
    public Transform player;
    private int currentWaypointIndex = 0;
    private bool isResting = false;
    private float restTimer = 0f;

    void Update()
    {
        if (isResting)
        {
            Rest();
        }
        else
        {
            Patrol();
            DetectPlayer();
        }
    }

    void Patrol()
    {
        if (waypoints.Length == 0)
        {
            return;
        }

        Transform targetWaypoint = waypoints[currentWaypointIndex];
        Vector2 direction = (targetWaypoint.position - transform.position).normalized;
        transform.position = Vector2.MoveTowards(transform.position, targetWaypoint.position, speed * Time.deltaTime);
        float distance = Vector2.Distance(transform.position, targetWaypoint.position);

        if (distance < 0.1f)
        {
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
            energy -= 10f;

            if (energy <= 0)
            {
                isResting = true;
                restTimer = 0f;
            }
        }
    }

    void Rest()
    {
        restTimer += Time.deltaTime;

        if (restTimer >= restTime)
        {
            energy = 100f;
            isResting = false;
        }
    }

    void DetectPlayer()
    {
        float distanceToPlayer = Vector2.Distance(transform.position, player.position);

        if (distanceToPlayer <= detectionRadius)
        {
            ChasePlayer();
        }
    }

    void ChasePlayer()
    {
        Vector2 direction = (player.position - transform.position).normalized;
        transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        energy -= 0.5f;

        if (energy <= 0)
        {
            isResting = true;
            restTimer = 0f;
        }
    }*/
}