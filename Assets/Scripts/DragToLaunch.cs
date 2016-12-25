using UnityEngine;
using System.Collections;

public class DragToLaunch : MonoBehaviour {

	public float baseThrust = 2.0f;

	public Vector3 MaxForce;
	public Vector3 MinForce;

	public Rigidbody PlayerRigidbody;
	public PlayerManager PlayerManagerScript;

	private Vector3 dragStartPosition;
	private Vector3 dragEndPosition;

	// Use this for initialization
	void Start () {
		PlayerRigidbody = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>();
		PlayerManagerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerManager>();
		Input.simulateMouseWithTouches = true;
	}

	void OnMouseDown() {
	}

	void Update () {

		if (Input.GetMouseButtonDown(0)) {
			dragStartPosition = Input.mousePosition;
		} else if (Input.GetMouseButtonUp(0)) {
			dragEndPosition = Input.mousePosition;

			Vector3 dragDifference = dragStartPosition - dragEndPosition;
			Vector3 thrustVector = baseThrust * (dragDifference.normalized + Vector3.one);

			print (thrustVector);
			print (dragDifference);

			if (MinForce.x > thrustVector.x || MinForce.y > thrustVector.y) {
				return;
			} else {
				if (PlayerManagerScript.InAir == false) {
					PlayerManagerScript.Launches++;
					PlayerRigidbody.AddForce(thrustVector);
				}
			}
		}
	}
}
