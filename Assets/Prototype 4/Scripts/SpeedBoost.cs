using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    public float moveSpeed = 30f;
    public float jumpSpeed = 30f;

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        switch(hit.gameObject.tag)
        {
            case "SpeedBoost":
                moveSpeed = 30f;
                break;
            case "JumpPad":
                jumpSpeed = 30f;
                break;

        }
    }

}
