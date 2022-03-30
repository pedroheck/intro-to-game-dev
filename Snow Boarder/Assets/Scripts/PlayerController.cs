using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount = 30f;
    [SerializeField] float baseSpeed = 35f;
    [SerializeField] float boostSpeed = 55f;

    Rigidbody2D rb2d;
    SurfaceEffector2D surfaceEffector2D;
    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>(); // Finds an SurfaceEffector2D in the world. Only works here because there's only 1 surface effector
    }

    // Update is called once per frame
    void Update()
    {
        RotatePlayer();
        RespondToBoost();
    }

    private void RespondToBoost()
    {
        // If we push up, then speed up. Otherwise, stays at normal speed
        if (Input.GetKey(KeyCode.UpArrow)){
            surfaceEffector2D.speed = boostSpeed;
        } else{
            surfaceEffector2D.speed = baseSpeed;
        }
    }

    private void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow)){
            rb2d.AddTorque(torqueAmount);
        }
        else if (Input.GetKey(KeyCode.RightArrow)){
            rb2d.AddTorque(-torqueAmount);
        }
    }
}
