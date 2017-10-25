using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour {

	public static AudioClip birdHitSound, birdFlapSound, pointGetSound;
	static AudioSource audioSrc;

	// Use this for initialization
	void Start () {

		birdHitSound = Resources.Load<AudioClip> ("birdHit");
		birdFlapSound = Resources.Load<AudioClip> ("birdFlap");
		pointGetSound = Resources.Load<AudioClip> ("pointGet");

		audioSrc = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public static void PlaySound (string clip)
	{
		switch (clip) {
		case "birdHit":
			audioSrc.PlayOneShot (birdHitSound);
			audioSrc.pitch = (Random.Range(.9f, 1.2f));
			break;
		case "birdFlap":
			audioSrc.PlayOneShot (birdFlapSound);
			audioSrc.pitch = (Random.Range(.9f, 1.2f));
			break;
		case "pointGet":
			audioSrc.PlayOneShot (pointGetSound);
			break;
		}
	}
}
