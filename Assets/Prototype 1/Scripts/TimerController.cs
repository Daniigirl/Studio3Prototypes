using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerController : MonoBehaviour
{
    public string failureScene;
    float currentTime = 0f;
    float startingTime = 10f;

    [SerializeField] Text countdownText;

    void Start()
    {
        currentTime = startingTime;
    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        if (currentTime <= 0)
        {
            currentTime = 0;
        }

        { 

            if (currentTime <= 0)
            {
                SceneManager.LoadScene(failureScene);
            }

        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "sand_clock")
        {
            currentTime += 5;
            Destroy(other.gameObject);
        }
    }

}
