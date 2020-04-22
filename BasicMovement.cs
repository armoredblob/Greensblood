using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    // Declare variables
    public float speed;
    public Transform mainCamera;
    CharacterController controller;
    private void Start()
    
    // Controller method
    {
        controller = GetComponent<CharacterController>();
    }
    
    // Assign keys 
    private void Update()
    {
        Vector3 moveDirection;
        moveDirection = Vector3.zero;
        if (Input.GetKey("w"))
        {
            moveDirection += mainCamera.forward;
        }
        if (Input.GetKey("s"))
        {
            moveDirection -= mainCamera.forward;
        }
        if (Input.GetKey("d"))
        {
            moveDirection += mainCamera.right;
        }
        if (Input.GetKey("a"))
        {
            moveDirection -= mainCamera.right;
        }
    
        // moveDirection method
        moveDirection.y = 0;
        moveDirection.Normalize();
        controller.SimpleMove(moveDirection * speed);
    }
}
