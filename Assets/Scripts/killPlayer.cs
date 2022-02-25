using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killPlayer : MonoBehaviour

{
    JonhMovement2 jm;
    private void OnTriggerEnter2D(Collision2D collision)
    {

         if(collision.gameObject.CompareTag("Player")){
             Destroy(gameObject);
             jm.resetPosition();

        }
    
    }
   
    
}
