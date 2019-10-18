using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BarIncrease : MonoBehaviour
{
   

    float fullTime = 5.0f;
    float currentTime = 0f;
    public void SheIncreases()
    {
            currentTime += Time.deltaTime*2;
 
            float ratio = currentTime / fullTime;
 
            Vector3 currentScale = transform.localScale;
            transform.localScale = new Vector3(Mathf.Clamp(ratio, 0f, 6f), currentScale.y, currentScale.z);           
    }
    void Update(){
        if (transform.localScale.x >= 6f){
            SceneManager.LoadScene(2);
        }
    }

}
