using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

public TargetScript targetScript1;
 public TargetScript2 targetScript2;
 public TargetScript3 targetScript3;
 private int round = 0;
 public bool  nextround=false;

  
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(targetScript1.Down);
        if (targetScript1.fire==true)
        {
            Debug.Log("YES1");
        }
       else if (targetScript2.fire == true)
        {
            Debug.Log("YES2");
        }
        else if (targetScript3.fire == true)
        {
            Debug.Log("YES3");
        }

        if (targetScript1.Down == true && targetScript2.Down == true && targetScript3.Down == true)
        {
            nextround = true;
           
            round += 1;
        }

        if (nextround == true)
        {
            targetScript1.Down = false;
            targetScript2.Down = false;
            targetScript3.Down = false;
        }
    }
}
