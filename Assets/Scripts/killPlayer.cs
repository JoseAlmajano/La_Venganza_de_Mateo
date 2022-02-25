using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class killPlayer : MonoBehaviour

{
    public JonhMovement2 jm;
    private void OnTriggerEnter2D(Collider2D collider)
    {

         if(collider.gameObject.CompareTag("Player")){
             
             jm.resetPosition();
                Destroy(collider.gameObject);
                SceneManager.LoadScene("scene2");
        }
    
    }
   

   
    
}
