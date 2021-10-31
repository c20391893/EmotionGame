using System;
using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEditor.MemoryProfiler;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
   public Text timeText;   
    public TargetScript targetScript1;
 public TargetScript2 targetScript2;
 public TargetScript3 targetScript3;
 public int round =1;
  public float timerDuration;
 [SerializeField] public bool Timerend1;
 [SerializeField] public bool Timerend2;
 public VictimScript1 victim1;
 public VictimScript2 victim2;
 public VictimScript3 victim3;
 public GameObject GameOver;
 public bool restartbool;
 


  
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        Timerend1=false;
        Timerend2 = false;
        restartbool = true;
    }

    // Update is called once per frame



    void Update()
    {
       
        Debug.Log(targetScript1.Down);

        if (targetScript1.Down == true && targetScript2.Down == !true && targetScript3.Down == !true)

        {
            Timerend1 = false;
            StartCoroutine(SetTimer1());
        }
        else if (targetScript1.Down == !true && targetScript2.Down == true && targetScript3.Down == !true)

        {
            Timerend1 = false;
            StartCoroutine(SetTimer1());
        }
        else if (targetScript1.Down == !true && targetScript2.Down == !true && targetScript3.Down == true)
        {
            Timerend1 = false;
            StartCoroutine(SetTimer1());
        }
        
        if(round>10)
        {
           victim1.anim.SetBool("rise",true); 
           victim2.anim.SetBool("rise",true); 
           victim3.anim.SetBool("rise",true); 
        }

        if (victim1.Down == true && victim2.Down == true && victim3.Down == true)
        {
            StartCoroutine(SetTimer2());
        }
        
    }
    

    IEnumerator SetTimer1()
    {
       
        yield return new WaitForSeconds(timerDuration);
           Timerend1 = true;
            if (Timerend1== true&&targetScript1.Down==true&&targetScript2.Down==true&&targetScript3.Down==true&&round<10)
            {
                targetScript1.Down = false;
                targetScript2.Down = false;
                targetScript3.Down = false;
                round += 1;
            }


            else if (Timerend1 == true&&targetScript1.Down==false&&targetScript2.Down==false&&targetScript3.Down==true&&round<10)
            { 
               // StartCoroutine(restart());
               StopCoroutine(SetTimer1());
               targetScript1.Down = true;
                targetScript2.Down = true;
                    // targetScript3.Down = false;
               
            }
            
            else if (Timerend1 == true&&targetScript1.Down==false&&targetScript2.Down==true&&targetScript3.Down==false&&round<10)
            {
               
                //targetScript1.Down = false;
                targetScript2.Down = false;
                //targetScript3.Down = false;
                
            }

            else if (Timerend1 == true&&targetScript1.Down==true&&targetScript2.Down==false&&targetScript3.Down==false&&round<10)
            {
                
                targetScript1.Down = false;
               // targetScript2.Down = false;
               // targetScript3.Down = false;
               
            }
            if (targetScript1.Down==true&&targetScript2.Down==true&&targetScript3.Down==true&&round==10)
            {
                StopCoroutine(SetTimer1());
                round +=1;
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

    IEnumerator SetTimer2()
    {
        yield return new WaitForSeconds(8);
        Timerend2 =true;

        if (Timerend2 == true)
        {
            GameOver.SetActive(true);
        }
    }

    IEnumerator restart()
    {
        yield return new WaitForSeconds(5);
        restartbool = true;
        {
            targetScript1.anim.SetBool("shot", false);
            targetScript2.anim.SetBool("shot", false);
            targetScript1.Down = false;
            targetScript2.Down = false;   
        }
    }
    
    }
    
           
            
                    
    
                
            
        






