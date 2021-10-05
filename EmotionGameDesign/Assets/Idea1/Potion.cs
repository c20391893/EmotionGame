using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Potion : MonoBehaviour
{
    private bool dragging;
    //public Component GetComponent<Sprite_Renderer>;
    private Vector2 offset,originalPosition;
    
    // Start is called before the first frame update
    void OnMouseDown()
    {
        dragging = true;

        offset = GetMousePos() - (Vector2)transform.position;
    }

     void Awake()
     {
         originalPosition = transform.position;
     }

     void OnMouseUp()
     {
         //if(Vector2.Distance(transform.position,Slot.transform.position))
         transform.position = originalPosition;
         dragging = false;
     }

    // Update is called once per frame
    void Update()
    {
        if (! dragging) return;

        var mousePosition = GetMousePos();

        transform.position = mousePosition - offset;
    }

    Vector2 GetMousePos()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition); 
    }
    
}
