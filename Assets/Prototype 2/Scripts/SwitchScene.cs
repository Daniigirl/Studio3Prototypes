using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("Out of the Woods Menu");
    }
}

