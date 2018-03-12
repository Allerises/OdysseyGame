using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopShaking : MonoBehaviour {

	Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		rb.velocity = Vector3.zero;
	}
}
