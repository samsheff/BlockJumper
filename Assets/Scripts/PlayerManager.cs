using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {

	public bool InAir = false;
	public int Launches = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SetOnGround() {
		InAir = false;
	}

	public void SetInAir() {
		InAir = true;
	}
}
