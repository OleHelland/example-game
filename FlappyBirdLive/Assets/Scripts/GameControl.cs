using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour {

	// Deklareringer
	public static GameControl instance;

	public GameObject gameOverText;
	public bool gameOver = false;

	public float scrollSpeed = -1.5f;

	public Text scoreText; 
	public int score = 0;

	public Text highestScoreText;
	public int highestScore;

	public DataControl dataControl;

	// Awake starter før void Start.
	void Awake () 
	{
		if (instance == null) 
		{
			instance = this;
		} else if (instance != this)
		{
			Destroy (gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (gameOver == true && Input.GetMouseButtonDown (0)) 
		{
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		}
	}

	// Æsj
	public void BirdScored () 
	{
		if (gameOver) 
		{
			return;
		}
		SoundManagerScript.PlaySound ("pointGet");
		score++;
		scoreText.text = "Score: " + score.ToString();
	}

	// Trigger Game Over staten
	public void BirdDied() 
	{
		gameOverText.SetActive (true);
		gameOver = true;
		dataControl.SubmitNewPlayerScore (score);
		highestScoreText.text = "High score: " + dataControl.GetHighestPlayerScore ().ToString ();
	}
}