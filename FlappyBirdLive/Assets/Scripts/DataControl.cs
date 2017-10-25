using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class DataControl : MonoBehaviour 
{

	//public RoundData[] allRoundData;

	private PlayerProgress playerProgress;

	// Use this for initialization
	void Start ()
	{
		DontDestroyOnLoad (gameObject);
		LoadPlayerProgress ();
	}
	
	/*
	public allRoundData GetCurrentRoundData () {
		return allRoundData [0];
	}
	*/

	public void SubmitNewPlayerScore(int score) 
	{
		if (score > playerProgress.highestScore) 
		{
			playerProgress.highestScore = score;
			SavePlayerProgress ();
		}
	}

	public int GetHighestPlayerScore()
	{
		return playerProgress.highestScore;
	}

	private void LoadPlayerProgress() 
	{
		playerProgress = new PlayerProgress ();

		if (PlayerPrefs.HasKey ("highestScore")) 
		{
			playerProgress.highestScore = PlayerPrefs.GetInt ("highestScore");
		}
	}

	private void SavePlayerProgress () 
	{
		PlayerPrefs.SetInt ("highestScore", playerProgress.highestScore);
	}
}