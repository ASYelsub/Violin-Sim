using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class DadBehavior : MonoBehaviour
{
    public AudioSource violinAudio;
    public AudioClip Audio0,Audio1,Audio2,Audio3,Audio4,Audio5,Audio6,Audio7,Audio8;

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
       // Transform myTransform = GetComponent<Transform>();
        int i = Random.Range(0,8);
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
        else if (i == 5){
            myAudioSource.clip = Audio5;
        }
        else if (i == 6){
            myAudioSource.clip = Audio6;
        }
        else if (i == 7){
            myAudioSource.clip = Audio7;
        }
        else if (i == 8){
            myAudioSource.clip = Audio8;
        }
        myAudioSource.PlayOneShot(myAudioSource.clip);
       
//        float mouseY = Input.GetAxis("Mouse Y");
  //      Vector3 mouseInput = new Vector3(0f,mouseY,0f);
    //    myTransform.Rotate(mouseInput.x,mouseInput.y,mouseInput.z);
       
        return null;
        //yield return new WaitForSeconds(myAudioSource.clip.length);
    }    
       // Debug.Log("Watch your bow, Abby!");
    public void PlayMusic(){
        violinAudio.UnPause();
    }
    public void StopMusic(){
        violinAudio.Pause();
    }
    
}
