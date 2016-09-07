using UnityEngine;
using System.Collections;

public class TemporaryObject : MonoBehaviour {

	public float SelfDestructDelay = 1.0f;
	public bool DestroyImmdediatly = true;

	void Awake () {
		if (DestroyImmdediatly) {
			Destroy (gameObject);
		}
	}
	
	// Update is called once per frame
	void Start () {
		StartCoroutine ("DestroyAfterDelay");
	}

	internal IEnumerator DestroyAfterDelay() {
		yield return new WaitForSeconds(SelfDestructDelay);
		Destroy (gameObject);
	}
}
