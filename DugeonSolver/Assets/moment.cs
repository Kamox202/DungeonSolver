using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moment : MonoBehaviour {

    float DirectionX;
    Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        rb.velocity = new Vector2(DirectionX* 10, 0);
	}
}
