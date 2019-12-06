using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{   
    public float moveSpeed = .5f;

    public Transform py;

    Vector3 movement; 

    // For applications of that input 

    private void FixedUpdate()
    {
        py.position = py.position + (movement * moveSpeed * Time.fixedDeltaTime);
    }
    
    //For movement Update is to get input from our player

    void Update()    
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        movement.z = 0;
    }
}
