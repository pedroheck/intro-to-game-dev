using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField] float moveSpeed = 17f;
    [SerializeField] float steerSpeed = 280;
    // Start is called before the first frame update
    void Start()
    {
        
    }

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
}
