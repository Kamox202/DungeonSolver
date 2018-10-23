using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour {
    
    [SerializeField]
    private float speed;
    private Button nagore;
    private Vector2 kierunek;
    BoxCollider2D player;
    
    // Use this for initialization
    void Start () {
        nagore.onClick.AddListener(Move);
	}

    private void Move()
    {
        throw new NotImplementedException();
    }

    // Update is called once per frame
    void Update () {
        Move(player);
	}
    public void Move(BoxCollider2D player)
    {
        transform.Translate(kierunek * speed * Time.deltaTime);
    }
}
