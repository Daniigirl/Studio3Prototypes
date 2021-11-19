using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SphereTrigger : MonoBehaviour
{
    public string myScene;

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Sphere")
        {
            SceneManager.LoadScene(myScene);
        }
    }

}

