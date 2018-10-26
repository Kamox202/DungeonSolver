using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ruch : MonoBehaviour {
    private float speed = 50;

    private Vector2 kierunek;
    
    public Button b_Gora, b_Dol, b_Prawo, b_Lewo;
    
    // Use this for initialization
    void Start () {
         b_Gora.onClick.AddListener(Gora);
         b_Dol.onClick.AddListener(Dol);
         b_Prawo.onClick.AddListener(Prawo);
         b_Lewo.onClick.AddListener(Lewo);
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
    
    
    private void Gora()
    {
        kierunek = Vector2.zero;
        kierunek += Vector2.up;
        Move();    
    }
    
    private void Dol()
    {
        kierunek = Vector2.zero;
        kierunek += Vector2.down;
        Move();    
    }
    
    private void Prawo()
    {
        kierunek = Vector2.zero;
        kierunek += Vector2.right;
        Move();    
    }
    
    private void Lewo()
    {
        kierunek = Vector2.zero;
        kierunek += Vector2.left;
        Move();    
    }
}
