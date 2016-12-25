using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour {

	public bool InAir = false;

	public Text ScoreText;
	public string ScoreTextBaseString = "Score: ";
	public int Score = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Launched() {
		Score++;
		ScoreText.text = ScoreTextBaseString + Score.ToString ();
	}

	public void SetOnGround() {
		InAir = false;
	}

	public void SetInAir() {
		InAir = true;
	}
}
