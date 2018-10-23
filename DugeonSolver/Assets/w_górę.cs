using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class w_górę : MonoBehaviour {
    public float moveSpeed;
    private bool moveRight;
    private Vector3 maxSpeed;

    void Update()
    {
        if (moveRight == true)
        { 
            GetComponent<Rigidbody2D>().AddForce(transform.right );
        }
        else if (moveRight == false)
        {
            GetComponent<Rigidbody2D>().AddForce(transform.right );
        }
    }

    public void MoveLeft()
    {
        transform.position -= transform.forward * Time.deltaTime * moveSpeed;

        // moveRight = false;
    }


    public void MoveRight()
    {
        transform.position += transform.forward * Time.deltaTime * moveSpeed;
    }
}
 // moveRight = true;
