using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMarble : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;

    public bool RotateAroundPlayer = true;

    public float RotationsSpeed = 100f;

    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;

        if (RotateAroundPlayer)
        {
            Quaternion camTurnAngle =
                Quaternion.AngleAxis(Input.GetAxis("Mouse X") * RotationsSpeed, Vector3.up);

            
        }
    }
}
