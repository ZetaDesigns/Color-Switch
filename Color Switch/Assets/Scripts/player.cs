using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

    public class player : MonoBehaviour {

	//setting variables
	public float jumpforce = 10f;
	public Rigidbody2D rb;
	public SpriteRenderer srenderer;
	public string currentColor;
	public Color colorCyan;
	public Color colorYellow;
	public Color colorPurple;
	public Color colorPink;

	// Gets executed on first loadup
	void Start ()
	{
		RandomColor ();

	}

	// Update is called once per frame
	void Update () {
		
		if(Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0)) {

			rb.velocity = Vector2.up * jumpforce;
		}
	}

	// Collision Detection
	void OnTriggerEnter2D (Collider2D col) {
	
        if (col.tag == "ColorChanger")
        {
            RandomColor();
            Destroy(col.gameObject);
            return;
        }
		if (col.tag != currentColor) {
		
			Debug.Log ("you suck");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
			
	}

	// Set a random color
	void RandomColor() {
	
		int index = Random.Range (0, 4);

		switch (index) 
		{

		case 0:
			currentColor = "Cyan";
			srenderer.color = colorCyan;
			break;
		case 1:
			currentColor = "Yellow";
			srenderer.color = colorYellow;
			break;
		case 2:
			currentColor = "Purple";
			srenderer.color = colorPurple;
			break;
		case 3:
			currentColor = "Pink";
			srenderer.color = colorPink;
			break;
		}

	}
}
