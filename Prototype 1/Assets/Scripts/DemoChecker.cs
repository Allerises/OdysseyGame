﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DemoChecker : MonoBehaviour {

	public GameObject[] cubes;
	bool done;
	int l;


	void Start () {
		l = cubes.Length;
	}

	// Update is called once per frame
	void Update () {
		done = true;
		for (int i = 0; i < l; i++) {
			if (!cubes[i].GetComponent<Demolished>().isDemolished()) {
				done = false;
			}
		}
	}

	public bool buildingDown () {
		return done;
	}
}
