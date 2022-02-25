using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{  
    public void LoadScene(string nombreScene){
       SceneManager.LoadScene(nombreScene);
    }

    public void Exit(){
       
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
        Application.Quit();
    }

}
