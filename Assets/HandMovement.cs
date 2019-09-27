using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//usage: move hand with mouse according to constraints
public class HandMovement : MonoBehaviour
{
    Rigidbody myRigidbody;
    Transform myTransform;
    Vector3 myInput;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        myTransform = GetComponent<Transform>();
    }

    void Update()
    {
        //we want z transform to increase when pushing mouse up and to decrease when pushing mouse down
        float mouseY = Input.GetAxis("Mouse Y");
        float mouseX = Input.GetAxis("Mouse X");
        myInput.y = 0f;
        myInput.x = 0f;
        myInput.z = mouseY;
    }

    void FixedUpdate(){
      
        
    }
}
