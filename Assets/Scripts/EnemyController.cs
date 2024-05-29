using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI lifeState;
    public GameObject objective;
    public Vector2 speedReference;
    public float currentTime = 0f;
    public float timer;
    public int energy;
    
    void Update()
    {
        if (energy > 0)
        {
            transform.position = Vector2.SmoothDamp(transform.position, objective.transform.position, ref speedReference, 0.5f);
        }
        else if (energy <= 0)
        {
            transform.position = Vector2.zero;
            currentTime = currentTime + Time.deltaTime;
            if (currentTime >= timer)
            {
                energy = 30;
                currentTime = 0;
            }
        }
        SetLifeText();
    }

    public void SetLifeText()
    {
        lifeState.text = " Energy: " + energy;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Node")
        {
            objective = collision.gameObject.GetComponent<NodeController>().SelecRandomAdjancent().gameObject;
            int weight = objective.GetComponent<NodeController>().GetNodeWeight();
            RestLife(weight);
        }
    }

    public void RestLife(int weight)
    {
        energy = energy - weight;
    }
}

/*using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI lifeState;
    public GameObject player;
    public GameObject objective;
    public Vector2 speedReference;
    public float currentTime = 0f;
    public float timer;
    public int energy;
    public float detectionRadius = 5f;
    public float patrolSpeed = 2f;
    public float chaseSpeed = 3f;

    private bool isChasingPlayer = false;
    private Vector2 initialPosition;

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        if (energy > 0)
        {
            if (isChasingPlayer)
            {
                ChasePlayer();
            }
            else
            {
                Patrol();
            }
        }
        else
        {
            Rest();
        }
        SetLifeText();
        DetectPlayer();
    }

    void Patrol()
    {
        transform.position = Vector2.SmoothDamp(transform.position, objective.transform.position, ref speedReference, 0.5f);
    }

    void ChasePlayer()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, chaseSpeed * Time.deltaTime);
        energy -= 1; // Reducir energ�a al perseguir al jugador
    }

    void Rest()
    {
        transform.position = initialPosition;
        currentTime += Time.deltaTime;
        if (currentTime >= timer)
        {
            energy = 30;
            currentTime = 0;
        }
    }

    void SetLifeText()
    {
        lifeState.text = " Energy: " + energy;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Node")
        {
            if (!isChasingPlayer) // Solo cambiar objetivo si no est� persiguiendo al jugador
            {
                objective = collision.gameObject.GetComponent<NodeController>().SelectRandomAdjacent().gameObject;
                int weight = objective.GetComponent<NodeController>().GetNodeWeight();
                RestLife(weight);
            }
        }
    }

    void RestLife(int weight)
    {
        energy -= weight;
    }

    void DetectPlayer()
    {
        float distanceToPlayer = Vector2.Distance(transform.position, player.transform.position);
        if (distanceToPlayer <= detectionRadius)
        {
            isChasingPlayer = true;
        }
        else
        {
            isChasingPlayer = false;
        }
    }
}*/