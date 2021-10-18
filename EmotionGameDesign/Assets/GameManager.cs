using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class GameManager : MonoBehaviour
{

public TargetScript targetScript1;
 public TargetScript2 targetScript2;
 public TargetScript3 targetScript3;
 private int round = 1;
 [SerializeField] public float timerDuration;
 [SerializeField] public bool Timerend1;
 [SerializeField] public bool Timerend2;


  
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        Timerend1=false;
        
    }

    // Update is called once per frame



    void Update()
    {
        Debug.Log(round);

        if (targetScript1.Down == true && targetScript2.Down == !true && targetScript3.Down == !true&&round<11)

        {
            Timerend1 = false;
            StartCoroutine(SetTimer1());
        }
        else if (targetScript1.Down == !true && targetScript2.Down == true && targetScript3.Down == !true&&round<11)

        {
            Timerend1 = false;
            StartCoroutine(SetTimer1());
        }
        else if (targetScript1.Down == !true && targetScript2.Down == !true && targetScript3.Down == true&&round<11)
        {
            Timerend1 = false;
            StartCoroutine(SetTimer1());
        }
    }
    

    IEnumerator SetTimer1()
    {
       
        yield return new WaitForSeconds(timerDuration);
           Timerend1 = true;
            if (Timerend1== true&&targetScript1.Down==true&&targetScript2.Down==true&&targetScript3.Down==true)
            {
                targetScript1.Down = false;
                targetScript2.Down = false;
                targetScript3.Down = false;
                round += 1;
            }


            else if (Timerend1 == true&&targetScript1.Down==false&&targetScript2.Down==false&&targetScript3.Down==true) 
            {
                targetScript1.Down = false;
                targetScript2.Down = false;
                targetScript3.Down = false; 
            }
            
            else if (Timerend1 == true&&targetScript1.Down==false&&targetScript2.Down==true&&targetScript3.Down==false) 
            {
                targetScript1.Down = false;
                targetScript2.Down = false;
                targetScript3.Down = false; 
            }

            else if (Timerend1 == true&&targetScript1.Down==true&&targetScript2.Down==false&&targetScript3.Down==false) 
            {
                targetScript1.Down = false;
                targetScript2.Down = false;
                targetScript3.Down = false; 
            }

            if (targetScript1.fire == true)
            {
                targetScript1.anim.SetBool("shot", true);
                targetScript1.Down = true;
            }
            
            if (targetScript1.Down == false)
            {
                    targetScript1.anim.SetBool("Down", false);
            } 
            if (targetScript2.Down == false)
            {
                    targetScript2.anim.SetBool("Down", false);
            }
            if (targetScript3.Down== false)
            {
                    targetScript3.anim.SetBool("Down", false);
            }
            
            
    }
    
    }
           
            
                    
    
                
            
        






