using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoChecker : MonoBehaviour {

	public GameObject[] cubes;
	bool done;
	bool[] destroyed;
	int l;


	void Start () {
		l = cubes.Length;
		destroyed = new bool[l];
	}

	// Update is called once per frame
	void Update () {
		done = true;
		for (int i = 0; i < l; i++) {
			destroyed[i] = cubes[i].GetComponent<Demolished>().isDemolished();
			if(!destroyed[i]) {
				done = false;
			}
		}
		Debug.Log(done);
	}
}
