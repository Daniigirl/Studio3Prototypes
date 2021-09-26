using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartDelay : MonoBehaviour
{
    public float startTime = 5;
    public float levelTime = 10;
    private bool isGameStarted = false;

    void Start()
    {
        Time.timeScale = 0f;
        //To Pause the game
    }

    void Update()
    {
        if (!isGameStarted)
        {
            startTime -= Time.deltaTime;
            if (startTime < 0)
            {
                //Start the game
                //Unpause
                Time.timeScale = 1f;
                isGameStarted = true;
            }
        }
        else
        {
            levelTime -= Time.deltaTime;
            if (levelTime < 0)
            {
                //Level Completed
            }
        }
    }
}

