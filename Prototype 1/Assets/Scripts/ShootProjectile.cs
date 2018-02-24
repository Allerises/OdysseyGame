using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootProjectile : MonoBehaviour {

	public GameObject[] loadout;
	public Transform other;
	public float force, offset;
	public Text UI;
	int i;

	void Start () {
		i = 0;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.X)) {
			i++;

			switch (i) {
			case 0:
				UI.text = "Ball";
				break;
			case 1:
				UI.text = "Explosive";
				break;
			}

			if (i == loadout.Length) {
				i = 0;
			}
		}

		Vector3 dir = (transform.position - other.transform.position).normalized;
		if (Input.GetKeyDown(KeyCode.F)) {
			Debug.DrawLine(transform.position, other.position, Color.red, 1);
			Rigidbody rb = Instantiate(
			                   loadout[i],
			                   new Vector3(
			                       transform.position.x,
			                       transform.position.y,
			                       transform.position.z + offset),
			                   Quaternion.identity).GetComponent<Rigidbody>();
			rb.velocity = dir * force;
		}
	}
}
