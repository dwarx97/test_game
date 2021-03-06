﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float forwardForce = 500f;
    public float movementForce = 50f;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, this.forwardForce * Time.deltaTime);
        //Debug.Log(this.Force);
        if (Input.GetKey(KeyCode.LeftArrow)) //sang trái
        {
            rb.AddForce(-this.movementForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.RightArrow)) //sang phải
        {
            rb.AddForce(this.movementForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            rb.AddForce(0, this.movementForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y <= -1f || rb.position.x <= -7.5f || rb.position.x >= 7.5f) // nhận diện người chơi rơi khỏi map
        {
           FindObjectOfType<GameManager>().EndGame();
        }
    }
}
