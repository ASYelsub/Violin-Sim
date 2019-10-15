using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarDecrease : MonoBehaviour
{
   

    float fullTime = 5.0f;
    float currentTime = 30.0f;
    public void SheDecreases()
    {
            currentTime -= Time.deltaTime;
 
            float ratio = currentTime / fullTime;
 
            Vector3 currentScale = transform.localScale;
            transform.localScale = new Vector3(Mathf.Clamp(ratio, 0f, 6f), currentScale.y, currentScale.z);           
    }
}
