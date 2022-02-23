using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField] float moveSpeed = 17f;
    [SerializeField] float slowSpeed = 12f;
    [SerializeField] float steerSpeed = 280f;
    [SerializeField] float boostSpeed = 25f;

    // Update is called once per frame
    void Update()
    {
        // Creating variables responsible for how much change will be applied in the movement
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;

        // Applying those changes to the object
        transform.Translate(0, moveAmount, 0); // Translates only in the objects Y-axis (relative vertical)
        transform.Rotate(0, 0, -steerAmount); // Rotates only on the Z-axis (since it is top-down view)
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Boost"){
            moveSpeed = boostSpeed;
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        moveSpeed = slowSpeed;    
    }
}
