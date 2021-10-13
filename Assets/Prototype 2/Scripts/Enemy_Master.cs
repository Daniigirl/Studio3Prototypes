using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_Master : MonoBehaviour
{
    public GameObject Player;
    public float Distance;
    public NavMeshAgent enemy;

    public bool isAngered;

    public NavMeshAgent _agent;

    void Update()
    {
        enemy.SetDestination(Player.transform.position);

        if(Distance <= 5)
        {
            isAngered = true;
        }
        if(Distance > 5f)
        {
            isAngered = false;
        }

        if (isAngered)
        {
            _agent.isStopped = false;
            _agent.SetDestination(Player.transform.position);
        }
        if (!isAngered)
        {
            _agent.isStopped = true;
        }
    }
}
