using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Potion : MonoBehaviour
{
    private bool dragging;
    
    private Vector2 offset;
    
    // Start is called before the first frame update
    void OnMouseDown()
    {
        dragging = true;

        offset = GetMousePos() - (Vector2)transform.position;
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
