using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownController : MonoBehaviour
{
    public int countdownTime = 10;
    public Text countdownDisplay;


    private void Start()
    {
        Time.timeScale = 0f;
        StartCoroutine(CountdownToStart());
    }


    IEnumerator CountdownToStart()
    {

        while (countdownTime > 0)
        {
            countdownDisplay.text = countdownTime.ToString();

            yield return new WaitForSecondsRealtime(1f);

            countdownTime--;
        }

        countdownDisplay.text = "GO!";

        yield return new WaitForSecondsRealtime(1f);

        countdownDisplay.gameObject.SetActive(false);
        Time.timeScale = 1f;
    }
}

