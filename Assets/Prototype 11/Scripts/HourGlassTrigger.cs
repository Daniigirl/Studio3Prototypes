using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HourGlassTrigger : MonoBehaviour
{
    AudioSource Hourglass;

    // Start is called before the first frame update
    void Start()
    {
        Hourglass = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Hourglass.Play();
    }
}
