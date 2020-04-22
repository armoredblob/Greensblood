using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CamMovement: MonoBehaviour
{
    public Transform player;
    public float rotateAmount;
    float lookX, lookY;
    void Update()
    {
        lookX = Input.GetAxis("Mouse X");
        lookY = Input.GetAxis("Mouse Y");
        
        if (lookX > 0)
        {
            transform.RotateAround(player.position, Vector3.up, rotateAmount);
            
        }
      
        else if (lookX < 0)
        {
            transform.RotateAround(player.position, Vector3.left, rotateAmount);
        }
            
            if (lookY > 0)
        {
            transform.RotateAround(player.position, transform.right, rotateAmount);
            
        }
      
        else if (lookY < 0)
        {
            transform.RotateAround(player.position, transform.right, -rotateAmount);
        }
        
        transform.LookAt(player);
    }
}