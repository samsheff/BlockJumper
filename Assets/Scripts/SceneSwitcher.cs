using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour {

	public bool AutoSwitch = false;
	public string AutoSwitchSceneName;

	// Use this for initialization
	void Start () {
		if (AutoSwitch) {
			SwitchToScene (AutoSwitchSceneName);
		}
	}
	
	// Update is called once per frame
	public void SwitchToScene (string sceneName) {
		SceneManager.LoadScene (sceneName);
	}
}
