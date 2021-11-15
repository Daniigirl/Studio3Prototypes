using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DragAndDrop : MonoBehaviour 
{
    private void OnMouseDrag()
    {
        transform.position = GetMousePos();
    }

    private Vector3 GetMousePos() 
      
    {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        return mousePos;
    }
}
