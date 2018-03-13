using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public string[] Scenes;

	// Use this for initialization
	public void PlayGame ()
	{
		int r = Random.Range(0, Scenes.Length);
		SceneManager.LoadScene(Scenes[r]);
	}

	public void QuitGame ()
	{
		Application.Quit ();
	}
}
