using System.Collections;
using System.Collections.Generic;
using UnityEditor.MemoryProfiler;
using UnityEngine;

public class VictimScript1: MonoBehaviour
{ 
    
    public Animator anim;
    public bool fire;
    public bool free;
   public bool Down;
    public GameManager gm;
    public CircleCollider2D myCollider;
      
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
        myCollider = GetComponent<CircleCollider2D>();
        anim.SetBool("rise",false);
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        fire = true;
        free = false;
    }

    
    
    public void Update()
    {
        if (fire == true)
        {
            anim.SetBool("shot", true);
            Down = true;
        }

        if (Down == true)
        {
            anim.SetBool("Down", true);  
        }

       
    }
    
}

