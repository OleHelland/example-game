using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour {

	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
		// Sørger for at bakgrunnen gjentar seg
		rb2d = GetComponent<Rigidbody2D> ();
		rb2d.velocity = new Vector2 (GameControl.instance.scrollSpeed, 0);
	}
	
	// Update is called once per frame
	void Update () {
		// Stopper scrollingen etter game over
		if (GameControl.instance.gameOver == true) {
			rb2d.velocity = Vector2.zero;
		}
	}
}