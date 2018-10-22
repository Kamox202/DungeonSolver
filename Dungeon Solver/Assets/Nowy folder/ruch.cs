using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ruch : MonoBehaviour {
    [SerializeField]
    private float speed;

    private Vector2 kierunek;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GetInput();
        Move();

    }

    public void Move() {
        transform.Translate(kierunek*speed*Time.deltaTime);
    }

    private void GetInput() {
        kierunek = Vector2.zero;

        if (Input.GetKeyDown(KeyCode.W))
        {
            kierunek += Vector2.up;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            kierunek += Vector2.down;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            kierunek += Vector2.left;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            kierunek += Vector2.right;
        }
    }
}
