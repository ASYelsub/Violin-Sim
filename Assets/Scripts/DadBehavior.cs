using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DadBehavior : MonoBehaviour
{
    public AudioClip audio0;
    public AudioClip audio1;
    public AudioClip audio2;
    public AudioClip audio3;
    public AudioClip audio5;
    /*void Update(){
        if(Input.GetKey(KeyCode.Space)){
            PickVoiceClip();
        }
    }*/
    void Start(){
        AudioSource myAudioSource = GetComponent<AudioSource>();
    }
    public void PickVoiceClip(){
        int i = Random.Range(0,5);
        Debug.Log(i);
        if (i == 0){
            myAudioSource.AudioClip = audio0;
        }
        else if (i == 1){

        }
        else if (i == 2){
            
        }
        else if (i == 3){
            
        }
        else if (i == 4){
            
        }
        else if (i == 5){
            
        }
    }    
       // Debug.Log("Watch your bow, Abby!");
        
    
}
