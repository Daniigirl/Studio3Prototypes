using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SphereTrigger : MonoBehaviour
{
    public string myScene;
    
    
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Sphere")
        {
            SceneManager.LoadScene(myScene);
        }
    }

}

