using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//usage: move hand with mouse according to constraints
public class HandMovement : MonoBehaviour
{
    public DadBehavior dadBehavior;
    public BarDecrease barDecrease;
    public BarIncrease barIncrease;
    Transform myTransform;
    public GameObject lowerArm;
    public GameObject bow;
    public GameObject upperArm;
    public float sideMultiplier;

    public AudioSource dadAudio; 
    public AudioSource violinAudio;

    float timer;

    void Start()
    {

        myTransform = GetComponent<Transform>();

    }

    void Update()
    {
        //we want z transform to increase when pushing mouse up and to decrease when pushing mouse down
        
        float mouseY = Input.GetAxis("Mouse Y");
        float mouseX = Input.GetAxis("Mouse X");
        //mouseY = Mathf.Clamp(mouseY, -1f, .5f);
        /*if (myTransform.localPosition.x > 1.051){
            mouseY = Mathf.Clamp(mouseY,0,50);
        }
        if (myTransform.localPosition.x < 0.838){
            mouseY = Mathf.Clamp(mouseY,-50,0);
        }*/
        /*if(myTransform.position.z > -0.66){
            mouseY = Mathf.Clamp(mouseY,0,100);
        }
        if(myTransform.position.z < -1.17){
            mouseY = Mathf.Clamp(mouseY,0,100);
        }*/
        Vector3 mouseInput = new Vector3(mouseY,0f,0f);
        //-mouseX*sideMultiplier
        myTransform.Translate(mouseInput);

        Debug.Log("myTransform.position.x = " + myTransform.position.x);
        
        //PROBLEMS!
        /*if (myTransform.position.x >= 0.7f || myTransform.position.x <= 1.2f){
        dadBehavior.PickVoiceClip();
        }*/
        if (myTransform.position.x <= 0.8f || myTransform.position.x >= 1.2f){
            barDecrease.SheDecreases();
            dadBehavior.StopMusic();
            if (!dadAudio.isPlaying){
            dadBehavior.PickVoiceClip();
            }
        }
        else if (Mathf.Abs(mouseY) > 0f){
            barIncrease.SheIncreases();
            dadBehavior.PlayMusic();
            timer = 10f;
        }
        else if (Mathf.Abs(mouseY) == 0f){
            timer -= 1;
            if(timer <= 0f){
            dadBehavior.StopMusic();
            }
            
        }

        /*bow.transform.Translate(new Vector3(0f,0f,-mouseY*.5f));
        
        lowerArm.transform.Rotate(new Vector3(0f,-mouseY*10f,0f));
        upperArm.transform.Rotate(new Vector3(0f,-mouseY*10f,0f));
        */

    }

}
