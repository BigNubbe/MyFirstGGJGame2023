using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slash : MonoBehaviour
{
    public Collider2D bose;
    public GameObject tree;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tree = GameObject.FindGameObjectWithTag("Kreator");
        bose = tree.GetComponent<Collider2D>();
    }

     public void OnTriggerEnter2D(Collider2D other)
    {
        EnemyHealth hp = other.GetComponent<EnemyHealth>();
        SpikeMove spk = other.GetComponent<SpikeMove>();

        if(other.CompareTag("Spiker"))
        {
        spk.KillSpike();
        }
    }

   
}
