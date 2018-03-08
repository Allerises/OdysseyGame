using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelDone : MonoBehaviour {

	public GameObject[] demolished;
	public GameObject[] KeepSafe;
	public UnityStandardAssets.Characters.FirstPerson.FirstPersonController c;
	public Text UI;
	bool done, oops = false;

	void Start() {
		demolished = GameObject.FindGameObjectsWithTag("1x1");
		KeepSafe = GameObject.FindGameObjectsWithTag("2x2");
	}



	// Update is called once per frame
	void Update () {
		done = true;
		foreach (GameObject e in demolished) {
			if (!e.GetComponent<DemoChecker>().buildingDown()) {
				done = false;
			}
		}

		foreach (GameObject e in KeepSafe) {
			if (e.GetComponent<DemoChecker>().buildingDown()) {
				oops = true;
			}
		}

		if (done) {
			UI.text = "Level Complete!\nPress M to return to menu or R to restart.";
		} else if(oops) {
			c.enabled = false;
			UI.text = "The wrong building fell!\nPress M to return to menu or R to restart.";
		}
	}
}
