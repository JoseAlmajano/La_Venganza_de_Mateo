using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambiarScene : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collider)
    {

         if(collider.gameObject.CompareTag("Player")){           
                Destroy(collider.gameObject);
                SceneManager.LoadScene("scene2");
        }
    
    }
}

   
    