using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyHealth : MonoBehaviour
{
   public int hp;
   public GameObject player;
   public DeadMenu ded;
   

   void Start()
   {

    hp = 2;
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
    Debug.Log(hp);
    hp -= dem;
   }
}
