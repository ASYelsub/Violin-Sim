using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BarIncrease : MonoBehaviour
{

    float fullTime = 5f;
    float currentTime = 0f;
    public void SheIncreases()
    {       
            Scene currentScene = SceneManager.GetActiveScene ();
            string sceneName = currentScene.name;
            if (sceneName == "Les Mis"){
                currentTime += Time.deltaTime*7;
            }
            if (sceneName == "Tuning"){
                currentTime += Time.deltaTime*5;
            }
            if (sceneName == "Caprice 24"){
                currentTime += Time.deltaTime*1.5f;
            }
 
            float ratio = currentTime / fullTime;
 
            Vector3 currentScale = transform.localScale;
            transform.localScale = new Vector3(Mathf.Clamp(ratio, 0f, 12f), currentScale.y, currentScale.z);           
    }
    void Update(){
        Scene currentScene = SceneManager.GetActiveScene ();
        string sceneName = currentScene.name;
        if (transform.localScale.x >= 12f){
            if(sceneName == "Tuning"){
            SceneManager.LoadScene("Les Mis");
            }
            if(sceneName == "Les Mis"){
                SceneManager.LoadScene("After Les Mis");
            }
            if(sceneName == "Caprice 24"){
                SceneManager.LoadScene("End Screen");
            }
        }
    }

}
