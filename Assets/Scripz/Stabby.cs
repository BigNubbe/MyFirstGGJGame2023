using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stabby : MonoBehaviour
{
    public float chargetime;
    public float chargecurr;
    public Mov movs;
    public float stabCD;
    public GameObject stab;
    public Animator anim;
    void Start()
    {
        chargecurr = chargetime;
        stab.GetComponent<BoxCollider2D>().enabled = false;
        stab.GetComponent<SpriteRenderer>().enabled = false;

    }

    void Update()
    {

        stabCD -= Time.deltaTime;
        if (stabCD <= 0)
        {
            if(Input.GetKey(KeyCode.Mouse1) || Input.GetKey(KeyCode.R))
            {
                anim.SetBool("Charging",true);
                chargecurr -= Time.deltaTime;
                movs.CanMove = false;
                stab.GetComponent<SpriteRenderer>().enabled = true;
                
                if(Input.GetKeyDown(KeyCode.Mouse0) && chargecurr <= 0)
                {
                    England();
                    
                }
            
                
            }
            if(Input.GetKeyUp(KeyCode.Mouse1))
            {
            chargecurr = chargetime;
            anim.SetBool("Charging", false);
            movs.CanMove = true;
            stab.GetComponent<BoxCollider2D>().enabled = false;
            stab.GetComponent<SpriteRenderer>().enabled = false;
            }
            
        }
    }

    public void England()
    {
        stabCD = 2;
        chargecurr = chargetime;
        stab.GetComponent<BoxCollider2D>().enabled = true;
        stab.GetComponent<SpriteRenderer>().enabled = false;
        anim.SetBool("SwingWep",true);
        Invoke("Unfreeze", 0.11f);
    }

    void Unfreeze()
    {
        stab.GetComponent<BoxCollider2D>().enabled = false;
        stab.GetComponent<SpriteRenderer>().enabled = false;
        movs.CanMove = true;
        anim.SetBool("SwingWep",false);
        anim.SetBool("Charging",false);
    }
}
