using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinController : MonoBehaviour
{
    public Transform SpawnPosition;
    public Transform coneObj, BubblegumObj, BoysenberryObj, PeachObj, ChocolateObj, MintObj, VanillaObj;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (gameObject.name == "bread board")
        {
            if (Gameplay.cuttingboardS1 == "empty")
            {
                Instantiate(coneObj, SpawnPosition.position, SpawnPosition.rotation);
            }
        }
    }
   
}
