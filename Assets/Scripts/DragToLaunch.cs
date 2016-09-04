using UnityEngine;
using System.Collections;

public class DragToLaunch : MonoBehaviour {

	public float baseThrust = 2.0f;

	public Vector3 MaxForce;
	public Vector3 MinForce;

	public Rigidbody PlayerRigidbody;

	private Vector3 dragStartPosition;
	private Vector3 dragEndPosition;

	// Use this for initialization
	void Start () {
		PlayerRigidbody = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>();
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
			Vector3 thrustVector = baseThrust * dragDifference.normalized;

			print (thrustVector);
			print (dragDifference);

			if (MinForce.x > thrustVector.x || MinForce.y > thrustVector.y) {
				return;
			} else {
				PlayerRigidbody.AddForce(thrustVector);
				iTweenEvent.GetEvent (Camera.main.gameObject, "MoveToPlayer").Start();
			}
		}
	}
}
