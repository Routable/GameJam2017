using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveCollision : MonoBehaviour {
    private bool canBeHit = true;
    public float invulnerable = 3;
    public static bool hit = false;
 

    
    void OnTriggerEnter2D(Collider2D collision)
    {
       
   
        hit = false;
        
        if (canBeHit && collision.name == "Test")
        {
            TaylorsMovement.playerAnim.SetTrigger("hitLeft");
            hit = true;
            DestroyObject(gameObject);
          
            
            
            GameOver.health--;
        }
    }

    public static bool getHit()
    {
        return hit;
    }


  
    private void Update()
    {
        if (!canBeHit)
        {
            invulnerable -= Time.deltaTime;
            if (invulnerable <= 0)
            {
                canBeHit = true;
                invulnerable = 3;
            }
        }
    }
}
