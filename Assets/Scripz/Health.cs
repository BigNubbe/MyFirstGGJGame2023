using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
   public int hp;
   public GameObject player;
   public DeadMenu ded;
   

   void Start()
   {
    player = GameObject.FindGameObjectWithTag("Pyer");

    hp = 9;
   }

   void Update()
   {
 
    if(hp <= 0)
    {
        
        ded.gameOver();
        Destroy(gameObject);
        
    }

   }

   public void Damaged(int dem)
   {
    hp -= dem;
   }
}
