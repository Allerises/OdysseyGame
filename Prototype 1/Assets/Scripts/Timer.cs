using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour {

	public Text timer;
	public Canvas start;
	public float timeLimit;

	void Start() {
		timer.text = "Time Remaining: " + timeLimit + "secs";
	}

	// Update is called once per frame
	void Update () {
		timeLimit -= Time.deltaTime;
		timer.text = timeLimit;
	}
}
