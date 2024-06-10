using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount = 10f; // variable for float amount
    [SerializeField] float boostSpeed = 30f;
    [SerializeField] float baseSpeed = 20f;


    Rigidbody2D rb2d; // declair variables
    SurfaceEffector2D surfaceEffector2D; // how surface will effect snowboading 
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>(); // get and store Rigidbody2D (kad suktūsi player)
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    void Update()
    {
        RotatePlayer();
        RespondToBoost();
    }

    void RespondToBoost()
    {

    }

    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(torqueAmount);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(-torqueAmount);
        }
    }
}
