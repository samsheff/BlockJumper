using UnityEngine;
using System.Collections;

public class PlayerBottomTrigger : MonoBehaviour {

	public PlayerManager PlayerManagerScript;

	// Use this for initialization
	void Start () {
		PlayerManagerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerManager>();
	}

	void OnTriggerEnter () {
		PlayerManagerScript.SetOnGround ();
	}

	void OnTriggerExit () {
		PlayerManagerScript.SetInAir ();
	}
}
