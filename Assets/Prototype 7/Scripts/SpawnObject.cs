using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public Transform SpawnPosition;
    public Vector3 startingPosition;

    private void Start()
    {
        startingPosition = transform.position;
    }

    private void OnMouseDown()
    {
        transform.position = SpawnPosition.position;
    }
    public void OnNextCustomerOrderButtonClicked()
    {
       
    }
}
