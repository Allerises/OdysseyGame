using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour {

	public Text timer, UI;
	public Canvas start;
	public float timeLimit;
	UnityStandardAssets.Characters.FirstPerson.FirstPersonController c;
	bool started = false;

	void Start() {
		timer.text = timeLimit.ToString() + " seconds remain";
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
			timer.text = timeLimit.ToString() + " remain";
		}
		if (timeLimit <= 0) {
			c.enabled = false;
			UI.text = "Time's up!\nPress M to return to menu or R to restart.";
		}
	}
}
