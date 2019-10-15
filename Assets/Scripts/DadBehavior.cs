using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class DadBehavior : MonoBehaviour
{
    public AudioClip Audio0;
    public AudioClip Audio1;
    public AudioClip Audio2;
    public AudioClip Audio3;
    public AudioClip Audio4;

   /*  float fullTime = 5.0f;
    float currentTime = 5.0f;*/

    void Update(){
        if(Input.GetKeyDown(KeyCode.Space)){
            PickVoiceClip();
        }
        /*if(Input.GetKey(KeyCode.RightShift)){
            currentTime -= Time.deltaTime;
 
            float ratio = currentTime / fullTime;
 
            Vector3 currentScale = transform.localScale;
            transform.localScale = new Vector3(Mathf.Clamp(ratio, 0f, 1f), currentScale.y, currentScale.z);   
        }*/
    }
    public IEnumerator PickVoiceClip(){
        AudioSource myAudioSource = GetComponent<AudioSource>();
        int i = Random.Range(0,5);
        //Debug.Log(i);
        if (i == 0){
            myAudioSource.clip = Audio0;
        }
        else if (i == 1){
            myAudioSource.clip = Audio1;
         }
        else if (i == 2){
            myAudioSource.clip = Audio2;
         }
        else if (i == 3){
            myAudioSource.clip = Audio3;
        }
        else if (i == 4){
            myAudioSource.clip = Audio4;
        }
        myAudioSource.Play();
        return null;
        //yield return new WaitForSeconds(myAudioSource.clip.length);
    }    
       // Debug.Log("Watch your bow, Abby!");
        
    
}
