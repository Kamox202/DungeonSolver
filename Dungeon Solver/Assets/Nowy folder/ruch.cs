using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ruch : MonoBehaviour {
	

    private float speed = 61;

    private Vector2 kierunek;
    
    public Button b_Gora, b_Dol, b_Prawo, b_Lewo, b_Wlacz, b_Wyczysc;
	
	////public int[] movement = new int[5];
	public List<int> ruchy = new List<int>();

	
	// dodawanie do listy 		ruchy.Add(3);
	// np. ruchy.ToArray();		tablica = lista.toArray();

	int ilRuchow = 0;
	int licznik = 0;
	
    
    // Use this for initialization
    void Start () {
         //b_Gora.onClick.AddListener(Gora);
		 b_Gora.onClick.AddListener(() => Movement(0));
		 
         //b_Dol.onClick.AddListener(Dol);
		 b_Dol.onClick.AddListener(() => Movement(1));
		 
         //b_Prawo.onClick.AddListener(Prawo);
		 b_Prawo.onClick.AddListener(() => Movement(2));
		 
         //b_Lewo.onClick.AddListener(Lewo);
		 b_Lewo.onClick.AddListener(() => Movement(3));
		 
		 b_Wlacz.onClick.AddListener(Trst);

		 b_Wyczysc.onClick.AddListener(Tsst);
	
    }
    
    // Update is called once per frame
    void Update () {

        //Move();
		

    }
	
	void OnGUI()
     {
		/*////if(ilRuchow==movement.Length)
		{
		Trst();	
		
		}
		*/

	 }

    public void Move() {
        transform.Translate(kierunek*speed*Time.deltaTime);
    }
    

		

    private void Gora()
    {
        kierunek += Vector2.up;
        Move();   
		kierunek = Vector2.zero;
    }
    
    private void Dol()
    {
        kierunek += Vector2.down;
        Move();   
		kierunek = Vector2.zero;
    }
    
    private void Prawo()
    {
        kierunek += Vector2.right;
        Move();
		kierunek = Vector2.zero;		
    }
    
    private void Lewo()
    {
        kierunek += Vector2.left;
        Move();
		kierunek = Vector2.zero;		
    }


	void Movement(int ruch)
	{
		Debug.Log(ruch);
		////movement[ilRuchow] = ruch;
		ruchy.Add(ruch);
		ilRuchow++;
	}

	 private void Trst()
	{
		while (licznik<ruchy.Count)
		{
			if (ruchy[licznik]==0)
			{
				Gora();
			}
			else if (ruchy[licznik]==1)
			{
				Dol();
			}
			else if (ruchy[licznik]==2)
			{
				Prawo();
			}
			else if (ruchy[licznik]==3)
			{
				Lewo();
			}
			licznik++;
		}
		for (int item = 0; item<ruchy.Count; item++)
			{
				Debug.Log(ruchy[item]);
			}

	}
	
	private void Tsst()
	{
		ruchy.Clear();
		licznik = 0;
	}
}
