using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public GameObject slashy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("LOL");
        Health hp = other.GetComponent<Health>();
        if(other.CompareTag("Pyer") && hp != null)
        {
        hp.Damaged(1);
        }
    }
}
