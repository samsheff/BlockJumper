using UnityEngine;
using System.Collections;

public class Pedestal : MonoBehaviour {

	public BoxCollider PedestalLandingPad;
	public int PedestalNumber = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider collider) {
		GameObject collidedObject = collider.gameObject;
		if (collidedObject.CompareTag ("Pedestal")) {
			GameManager.instance.CurrentPedestal++;
		}
	}
}
