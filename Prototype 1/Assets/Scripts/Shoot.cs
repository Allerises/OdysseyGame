using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

	public GameObject obj;
	Rigidbody rb;
	public float force;
	float timer;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		rb.velocity *= force;
		timer = 5;
	}

	void Update () {
		timer -= Time.deltaTime;
		if (timer <= 0 || transform.position.y <= -2f) {
			Destroy(obj);
		}
	}
}
