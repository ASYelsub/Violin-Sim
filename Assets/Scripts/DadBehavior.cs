using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class DadBehavior : MonoBehaviour
{
    public AudioSource violinAudio;
    public AudioClip LesMis1,LesMis2,LesMis3,LesMis4,LesMis5,LesMis6;

    public AudioClip Tuning1,Tuning2,Tuning3,Tuning4,Tuning5,Tuning6,Tuning7,Tuning8,Tuning9;

    public AudioClip Paganini1,Paganini2,Paganini3,Paganini4,Paganini5,Paganini6;

   /*  float fullTime = 5.0f;
    float currentTime = 5.0f;*/

    void Update(){
        if(Input.GetKeyDown(KeyCode.Space)){
            PickVoiceClip(1);
        }
        /*if(Input.GetKey(KeyCode.RightShift)){
            currentTime -= Time.deltaTime;
 
            float ratio = currentTime / fullTime;
 
            Vector3 currentScale = transform.localScale;
            transform.localScale = new Vector3(Mathf.Clamp(ratio, 0f, 1f), currentScale.y, currentScale.z);   
        }*/
    }
    public IEnumerator PickVoiceClip(int scene){
        AudioSource myAudioSource = GetComponent<AudioSource>();
       // Transform myTransform = GetComponent<Transform>();
        //Debug.Log(i);
        if (scene == 1){
            int i = Random.Range(0,8);
            if (i == 0){
                myAudioSource.clip = Tuning1;
            }
            else if (i == 1){
                myAudioSource.clip = Tuning2;
            }
            else if (i == 2){
                myAudioSource.clip = Tuning3;
            }
            else if (i == 3){
                myAudioSource.clip = Tuning4;
            }
            else if (i == 4){
                myAudioSource.clip = Tuning5;
            }
            else if (i == 5){
                myAudioSource.clip = Tuning6;
            }
            else if (i==6){
                 myAudioSource.clip = Tuning7;
            }
            else if (i==7){
                 myAudioSource.clip = Tuning8;
            }
            else if (i==8){
                 myAudioSource.clip = Tuning9;
            }
        }
        else if (scene == 2){
            int i = Random.Range(0,5);
            if (i == 0){
                myAudioSource.clip = LesMis1;
            }
            else if (i == 1){
                myAudioSource.clip = LesMis2;
            }
            else if (i == 2){
                myAudioSource.clip = LesMis3;
            }
            else if (i == 3){
                myAudioSource.clip = LesMis4;
            }
            else if (i == 4){
                myAudioSource.clip = LesMis5;
            }
            else if (i == 5){
                myAudioSource.clip = LesMis6;
            }
        }
        else if (scene == 3){
            int i = Random.Range(0,5);
            if (i == 0){
                myAudioSource.clip = Paganini1;
            }
            else if (i == 1){
                myAudioSource.clip = Paganini2;
            }
            else if (i == 2){
                myAudioSource.clip = Paganini3;
            }
            else if (i == 3){
                myAudioSource.clip = Paganini4;
            }
            else if (i == 4){
                myAudioSource.clip = Paganini5;
            }
            else if (i == 5){
                myAudioSource.clip = Paganini6;
            }
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
