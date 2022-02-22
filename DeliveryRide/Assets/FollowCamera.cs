using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject target; // So we can pick the target object from the inspector window in Unity
    // The camera's position should follow the player's (Car) position
    void LateUpdate() // Here we're using LateUpdate so the position update is the last event to happen in the frame. Using just Update works, but it could behave weirdly in some circumstances
    {
        transform.position = target.transform.position + new Vector3 (0, 0, -10); // "+ new Vector3 (0, 0, -10)" is to take the camera off the plane 
    }
}
