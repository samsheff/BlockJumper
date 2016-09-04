using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {

	public Vector3 FollowAxis = new Vector3(1, 0, 0);
	public Vector3 MinMovementVector;
	public Transform PlayerTransform;

	// Use this for initialization
	void Start () {
		if (!PlayerTransform) {
			PlayerTransform = GameObject.FindGameObjectWithTag ("Player").transform;
		}
	}
	
	// Update is called once per frame
	public void Update() {
		Vector3 movementVector = FollowAxis;
		movementVector.Scale (PlayerTransform.position);

		if (MinMovementVector.x < Mathf.Abs(movementVector.x) || MinMovementVector.y < Mathf.Abs(movementVector.y) || MinMovementVector.z < Mathf.Abs(movementVector.z))
			transform.Translate (movementVector);
	}
}
