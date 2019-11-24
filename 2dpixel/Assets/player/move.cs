﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    public CharacterController2D controller;

    public float runspeed = 40f;

    float horizontalMove = 0f;

    bool Jump = false;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal")* runspeed;

        if (Input.GetButtonDown("Jump"))
        {
            Jump = true;
        }
       
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, Jump);
        Jump = false;
      
    }
}