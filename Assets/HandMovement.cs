﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//usage: move hand with mouse according to constraints
public class HandMovement : MonoBehaviour
{
    Transform myTransform;
    public GameObject lowerArm;
    public GameObject bow;
    public GameObject upperArm;
    void Start()
    {

        myTransform = GetComponent<Transform>();

    }

    void Update()
    {
        //we want z transform to increase when pushing mouse up and to decrease when pushing mouse down
        float mouseY = Input.GetAxis("Mouse Y");
        float mouseX = Input.GetAxis("Mouse X");
        Vector3 mouseInput = new Vector3(mouseX,mouseY,0f);
        /*bow.transform.Translate(new Vector3(0f,0f,-mouseY*.5f));
        
        lowerArm.transform.Rotate(new Vector3(0f,-mouseY*10f,0f));
        upperArm.transform.Rotate(new Vector3(0f,-mouseY*10f,0f));
*/
        myTransform.Translate(0f,0f,-mouseY*.25f);
    
         

    }

}
