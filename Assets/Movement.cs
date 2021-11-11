using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    void Start()
    {

    }
    
       

    void Update() { 
    
        float speed = 2;
    float maxDistanceToMove = speed * Time.deltaTime;

    transform.position += Vector3.right * Input.GetAxis("Horizontal") *maxDistanceToMove;

    } 

}