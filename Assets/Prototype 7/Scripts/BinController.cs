using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinController : MonoBehaviour
{
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
                Instantiate(coneObj, new Vector2(6.5f, -3f), coneObj.rotation);
                Instantiate(VanillaObj, new Vector2(6.55f, -7f), VanillaObj.rotation);
                Gameplay.cuttingboardS1 = "full";
            }
        }
    }
}
