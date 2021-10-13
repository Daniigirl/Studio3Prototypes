using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    private Vector3 respawn_point;

    private void Start()
    {
        respawn_point = this.gameObject.transform.position;
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other);
        if (other.gameObject.tag == "Obstacle")
        {
            this.gameObject.transform.position = respawn_point;
        }
    }
}





