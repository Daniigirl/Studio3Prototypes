using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoNotDestroy : MonoBehaviour
{
    public string sceneName;
    public float waitTime;
    public Animator musicAnim;
    private void Awake()
    {
        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("Game Music");
        if(musicObj.Length > 1)
        {
            Destroy(this.gameObject);

        }
        DontDestroyOnLoad(this.gameObject);

       
    }
     
    
}
