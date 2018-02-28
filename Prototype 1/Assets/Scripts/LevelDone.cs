using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelDone : MonoBehaviour {

	public GameObject[] demolished;
	public Text UI;
	bool done;



	// Update is called once per frame
	void LateUpdate () {
		done = true;
		foreach (GameObject e in demolished) {
			if (!e.GetComponent<DemoChecker>().buildingDown()) {
				done = false;
			}
		}
		Debug.Log(done);
		if (done) {
			UI.text = "Level Complete";
		}
	}
}
