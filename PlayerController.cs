using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount = 10f; // variable for float amount
    Rigidbody2D rb2d; // declair variables
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>(); // get and store Rigidbody2D (kad suktūsi player)
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(torqueAmount);
        }
         else if(Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(-torqueAmount);
        }
    }
}
