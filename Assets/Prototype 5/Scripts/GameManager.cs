using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip music;

    public bool startPlaying;

    public BeatScroller theBS;

    public static GameManager instance;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!startPlaying)
        {
            
            
                startPlaying = true;
                theBS.hasStarted = true;

                audioSource.clip = music;
                audioSource.Play();
           
        }
    }

    public void NoteHit()
    {
        Debug.Log("Hit on Time");
    }

    public void NoteMissed()
    {
        Debug.Log("Missed Note");
    }
}