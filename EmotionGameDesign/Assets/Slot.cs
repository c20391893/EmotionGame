using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{

     GameObject Potion;
      // Component Potion.GetComponent<ReferencedScript>();
      
   
    // Start is called before the first frame update
   public void placed()
   {
       if (Vector2.Distance(transform.position, Potion.transform.position) < 3)
       {
           
       }
       
   }

    // Update is called once per frame
    void Update()
    {
        
    }
}
