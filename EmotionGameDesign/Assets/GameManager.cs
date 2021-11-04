using System;
using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
  // public Text timeText;   
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
 public bool restartbool1;
 public bool restartbool2;
 public bool restartbool3;
 public bool restartbool4;
 public bool restartbool5;
 public bool restartbool6;
 public bool final;
public GameObject text;
public RoundText roundtext;
public  GameObject issue;
public GameObject stage1;
public GameObject stage2;
public GameObject stage3;
 


  
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        Timerend1=false;
        Timerend2 = false;
        restartbool1 =true;
        restartbool2 =true;
        final = false;
    }

    // Update is called once per frame



    void Update()
    {
       
       // Debug.Log(round);
       stage1.gameObject.SetActive(true);
       stage2.gameObject.SetActive(false);
       stage3.gameObject.SetActive(false);
        if (targetScript1.Down == true && targetScript2.Down == !true && targetScript3.Down == !true)
        {
            restartbool3 = false;
            restartbool2 = false;
            restartbool1 = false;
            Timerend1 = false;
            StartCoroutine(SetTimer1());
        }
        else if (targetScript1.Down == !true && targetScript2.Down == true && targetScript3.Down == !true)

        {
            restartbool3 = false;
            restartbool2 = false;
            restartbool1 = false;
            Timerend1 = false;
            StartCoroutine(SetTimer1());
        }
        else if (targetScript1.Down == !true && targetScript2.Down == !true && targetScript3.Down == true)
        {
            restartbool3 = false;
            restartbool2 = false;
            restartbool1 = false;
            Timerend1 = false;
            StartCoroutine(SetTimer1());
            
        }

        if (round >= 5)
        {
            stage1.gameObject.SetActive(false);
            stage2.gameObject.SetActive(true);
            stage3.gameObject.SetActive(false); 
        }
        if(round>10)
        {
            StartCoroutine(Final());
           victim1.anim.SetBool("rise",true); 
           victim2.anim.SetBool("rise",true); 
           victim3.anim.SetBool("rise",true);
           roundtext.roundText.gameObject.SetActive(false);
           stage3.gameObject.SetActive(true);
           stage2.gameObject.SetActive(false);
           stage1.gameObject.SetActive(false);
        }

        if (victim1.Down == true && victim2.Down == true && victim3.Down == true)
        {
            StartCoroutine(SetTimer2());
        }

        if (victim1.fire == true || victim2.fire == true || victim3.fire == true)
        {
          StopCoroutine(Final());
            text.SetActive(false);
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
                StartCoroutine(restart1());
               
               targetScript1.anim.SetBool("Restart", true);
                targetScript2.anim.SetBool("Restart",true);
                   
               
            }
            
            else if (Timerend1 == true&&targetScript1.Down==false&&targetScript2.Down==true&&targetScript3.Down==false&&round<10)
            {
                StartCoroutine(restart2());
                targetScript1.anim.SetBool("Restart", true);
                targetScript3.anim.SetBool("Restart",true);
                
            }

            else if (Timerend1 == true&&targetScript1.Down==true&&targetScript2.Down==false&&targetScript3.Down==false&&round<10)
            {
                
                StartCoroutine(restart3());
                targetScript2.anim.SetBool("Restart", true);
                targetScript3.anim.SetBool("Restart",true);
               
            }
            
            else if (Timerend1==true&&targetScript1.Down==false&&targetScript2.Down==true&&targetScript3.Down==true&&round < 10)
            {
                StartCoroutine(restart4()); 
                targetScript1.anim.SetBool("Restart", true);
            }
            
            else if (Timerend1==true&&targetScript1.Down==true&&targetScript2.Down==false&&targetScript3.Down==true&&round < 10)
            {
                StartCoroutine(restart5());
                targetScript2.anim.SetBool("Restart", true);
            }
            
            else if (Timerend1==true&&targetScript1.Down==false&&targetScript2.Down==true&&targetScript3.Down==false&&round < 10)
            {
                StartCoroutine(restart6());
                targetScript3.anim.SetBool("Restart", true);
            }
            
            if (targetScript1.Down==true&&targetScript2.Down==true&&targetScript3.Down==true&&round==10)
            {
                StopCoroutine(SetTimer1());
                round +=1;
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
            issue.SetActive(false);
        }
    }

    IEnumerator restart1()
    {
        yield return new WaitForSeconds(2);
        restartbool1 = true;
        if(restartbool1 == true)
        {
            
            targetScript1.anim.SetBool("Restart",false);
            targetScript2.anim.SetBool("Restart",false);
            targetScript3.Down = false;
        }
    }
    
    
    IEnumerator restart2()
    {
        yield return new WaitForSeconds(2);
        restartbool2 = true;
        if(restartbool2==true)
        {
            
            targetScript1.anim.SetBool("Restart",false);
            targetScript3.anim.SetBool("Restart",false);
            targetScript2.Down = false;
        }
    }
    
    IEnumerator restart3()
    {
        yield return new WaitForSeconds(2);
        restartbool3 = true;
        if(restartbool3==true)
        {
            
            targetScript2.anim.SetBool("Restart",false);
            targetScript3.anim.SetBool("Restart",false);
            targetScript1.Down = false;
        }
    }

    IEnumerator restart4()
    {
        yield return new WaitForSeconds(2);
        
            
            targetScript1.anim.SetBool("Restart", false);
            targetScript2.Down = false;
            targetScript3.Down = false;
        
    }
    
    IEnumerator restart5()
    {
        yield return new WaitForSeconds(2);
        restartbool5 = true;
        if(restartbool5==true)
        {
            
            targetScript2.anim.SetBool("Restart",false);
            targetScript1.Down = false;
            targetScript3.Down = false;
        }
    }
    
    IEnumerator restart6()
    {
        yield return new WaitForSeconds(2);
        restartbool6 = true;
        if(restartbool6==true)
        {
            
            targetScript3.anim.SetBool("Restart",false);
            targetScript1.Down = false;
            targetScript2.Down = false;
        }
    }
    IEnumerator Final()
    {
        yield return new WaitForSeconds(5);
        text.SetActive(true);
        if (victim1.fire == true || victim2.fire == true || victim3.fire == true)
        {
            text.SetActive(false);
        }
            
       
    }
    }
    
           
            
                    
    
                
            
        






