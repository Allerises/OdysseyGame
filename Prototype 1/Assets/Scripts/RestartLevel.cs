using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour {

	
	// Use this for initialization
	void Start () {

	}

	void Update () {
		if (Input.GetKeyDown(KeyCode.R)) {
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
		} else if (Input.GetKeyDown(KeyCode.M)) {
			SceneManager.LoadScene("Menu");
		}
	} 
}
