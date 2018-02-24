using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour {

	Rigidbody rb;
	public GameObject obj, ExplosionCollider;
	public float explosionForce, mod, radius, force;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		rb.velocity *= force;
		ExplosionCollider.SetActive(false);
	}

	void Update () {
		if (Input.GetKeyDown(KeyCode.E)) {
			transform.parent = null;
			ExplosionCollider.SetActive(true);
			rb.AddExplosionForce(explosionForce, transform.position, radius, mod);
		}
	}

	void OnTriggerEnter (Collider other) {
		rb.velocity = Vector3.zero;
		rb.useGravity = false;
		transform.parent = other.transform;
		transform.rotation = Quaternion.identity;
	}

	void OnTriggerExit (Collider other) {
		Destroy(obj);
	}
}
