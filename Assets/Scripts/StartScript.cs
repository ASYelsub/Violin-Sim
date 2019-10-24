using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{
 
    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        if(Input.GetKeyDown(KeyCode.Mouse0) && sceneName == "Start Screen"){
            SceneManager.LoadScene("Tuning");
        }
        if(Input.GetKeyDown(KeyCode.Mouse0) && sceneName == "After Les Mis"){
            SceneManager.LoadScene("Caprice 24");
        }
        
    }
}
