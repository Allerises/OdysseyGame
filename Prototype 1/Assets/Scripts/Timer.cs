using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour {

	public Text timer;
	public Canvas start;
	public float timeLimit;
	UnityStandardAssets.Characters.FirstPerson.FirstPersonController c;
	bool started = false;

	void Start() {
		timer.text = timeLimit.ToString() + " remaining";
		c = GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>();
		c.enabled = false;
	}

	// Update is called once per frame
	void Update () {
		if (!started && Input.GetKeyDown(KeyCode.E)) {
			started = true;
			start.enabled = false;
			c.enabled = true;
		}

		if (started) {
			timeLimit -= Time.deltaTime;
			timer.text = timeLimit.ToString() + " remaining";
		}
		if (timeLimit <= 0) {
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
		}
	}
}
