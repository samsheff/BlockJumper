using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelReset : MonoBehaviour {
	
	// Update is called once per frame
	void OnTriggerEnter (Collider collider) {
		if (collider.gameObject.tag.Equals ("Player")) {
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}
}
