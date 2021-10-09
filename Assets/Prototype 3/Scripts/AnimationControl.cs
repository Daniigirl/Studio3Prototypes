using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour
{
    public GameObject femaleC;

    public void PlayIdle()
    {
        femaleC.GetComponent<Animation>().Play("idle");
    }

    public void PlayWalk()
    {
        femaleC.GetComponent<Animation>().Play("walk");      
    }

    public void PlaySprint()
    {
        femaleC.GetComponent<Animation>().Play("sprint");
    }
}
