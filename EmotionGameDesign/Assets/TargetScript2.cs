using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class TargetScript2 : MonoBehaviour
    {
        public Animator anim;
        public bool fire;
        public bool free;
        public bool Down;
        public GameManager gm;
        public CircleCollider2D myCollider;
        public AudioSource audiodata;
    
        // Start is called before the first frame update
        void Start()
        {
            anim = GetComponentInChildren<Animator>();
            myCollider = GetComponent<CircleCollider2D>();
            audiodata = GetComponent<AudioSource>();
        }

        // Update is called once per frame
        void OnMouseDown()
        {
            fire = true;
            free = false;
        }

        void OnMouseUp()
        {
            free = true;
            fire = false;
        }
    
        public void Update()
        {
            if (fire == true)
            {
                anim.SetBool("shot", true);
                Down = true;
                audiodata.Play();
            }

            if (free == true)
            {
                anim.SetBool("shot", false);     
            }

            if (Down == true)
            {
                anim.SetBool("Down", true);
                //gm.roundcounter += 1;
            }
        }
    }


