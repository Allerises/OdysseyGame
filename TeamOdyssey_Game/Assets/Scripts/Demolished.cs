using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demolished : MonoBehaviour {

	bool demolished;
	public float height;

	// Update is called once per frame
	void Update () {
		if (transform.position.y < height) {
			demolished = true;
		} else {
			demolished = false;
		}
	}

	public bool isDemolished () {
		return demolished;
	}
}
