﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeMove : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector3 Target;
    public Transform PPos;
    public GameObject Spike;
    public GameObject Boss;
    public GameObject Tiles;
    public Vector3 Targetscale;
    public float StretchDurat;
    Vector3 Currentscale;
    bool extend;
    float t = 0;

    public int flag = 0;
    int x;


    public GameObject bose;
    public EnemyHealth hp;

    void Start()
    {
    Targetscale = new Vector3(1,3,1); //change to (1,3,0)
    Currentscale = Vector3.one;
    t = 0;
     PPos = GameObject.FindGameObjectWithTag("Pyer").transform;
     rb = Spike.GetComponent<Rigidbody2D>();

     Boss = GameObject.FindGameObjectWithTag("Kreator");
     Tiles = GameObject.FindGameObjectWithTag("Tiles");
     Physics2D.IgnoreCollision(Boss.GetComponent<Collider2D>(), GetComponent<Collider2D>());
    Physics2D.IgnoreCollision(Tiles.GetComponent<Collider2D>(), GetComponent<Collider2D>());
     x = 5;
    StretchDurat = 0.11f;
        flag = 0;


        
    }
    // Update is called once per frame
    void Update()
    {


        bose = GameObject.FindGameObjectWithTag("Kreator");
        hp = bose.GetComponent<EnemyHealth>();
        Target = new Vector3(PPos.position.x, -2.66f, 0f);
        Vector2 newPos = Vector2.MoveTowards(rb.position, Target, x * Time.fixedDeltaTime);
        rb.MovePosition(newPos);

        if(Vector2.Distance(Target, rb.position) <= 0.2f)
       {
        //Stop move then stretch upwards
        Invoke("Stretchy", 0.45f);
        
        x = 0;
        
        
       }
       if(extend)
       {
        t += Time.deltaTime / StretchDurat;
        Vector3 newScale = Vector3.Lerp(Currentscale, Targetscale, t);
        transform.localScale = newScale;
        //Vector3
       }

       
    }

    void DestroyProjectile()
    {
        Destroy(gameObject);
    }

    void Stretchy()
    {
        extend = true;
        flag = 1;
        
        Invoke("Ded",4);
        
    }
    void Ded()
    {
        flag = 2;
        Destroy(gameObject);
        
    }

    public void KillSpike()
    {
        hp.Damaged(1);
        Invoke("Ded",0.0001f);

    }

 
}
