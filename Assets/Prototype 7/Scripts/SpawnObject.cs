using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public Transform SpawnPosition;
    public Vector3 startingPosition;
    public GameObject order;

    private void Start()
    {
        startingPosition = transform.position;
    }

    private void OnMouseDown()
    {
        Instantiate(order, SpawnPosition.position, SpawnPosition.rotation);
        
    }
}
