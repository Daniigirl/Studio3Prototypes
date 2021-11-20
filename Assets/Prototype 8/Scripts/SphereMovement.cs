using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SphereMovement : MonoBehaviour
{
    private NavMeshAgent _agent;

    public GameObject Player;

    public float EnemyDistanceRun = 4f;

    // Start is called before the first frame update
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, Player.transform.position);

        Debug.Log("Distance: " + distance);

        if (distance < EnemyDistanceRun)
        {
            Vector3 dirToPlayer = transform.position - Player.transform.position;

            Vector3 newPos = transform.position + dirToPlayer;

            _agent.SetDestination(newPos);
        }
        //We will check if enemy can flee to the direction opposite from the player, we will check if there are obstacles
        bool isDirSafe = false;

        //We will need to rotate the direction away from the player if straight to the opposite of the player is a wall
        float vRotation = 0;

        while (!isDirSafe)
        {
            //Calculate the vector pointing from Player to the Enemy
            Vector3 dirToPlayer = transform.position - Player.transform.position;

            //Calculate the vector from the Enemy to the direction away from the Player the new point
            Vector3 newPos = transform.position + dirToPlayer;

            //Rotate the direction of the Enemy to move
            newPos = Quaternion.Euler(0, vRotation, 0) * newPos;

            //Shoot a Raycast out to the new direction with 5f length (as example raycast length) and see if it hits an obstacle
            bool isHit = Physics.Raycast(transform.position, newPos, out RaycastHit hit, 3f);

            if (hit.transform == null)
            {
                //If the Raycast to the flee direction doesn't hit a wall then the Enemy is good to go to this direction
                //NavMeshAgent.SetDestination(newPos);
                isDirSafe = true;
            }

            //Change the direction of fleeing is it hits a wall by 20 degrees
            if (isHit && hit.transform.CompareTag("Wall"))
            {
                vRotation += 20;
                isDirSafe = false;
            }
            else
            {
                //If the Raycast to the flee direction doesn't hit a wall then the Enemy is good to go to this direction
                //NavMeshAgent.SetDestination(newPos);
                isDirSafe = true;
            }
        }

    }
}
