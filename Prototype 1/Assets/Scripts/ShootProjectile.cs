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
			if (i == loadout.Length) {
				i = 0;
			}
			switch (i) {
			case 0:
				UI.text = "Ball";
				break;
			case 1:
				UI.text = "Explosive";
				break;
			}
		}

		Vector3 dir = (other.position - transform.position).normalized;
		if (Input.GetKeyDown(KeyCode.F)) {
			Debug.DrawLine(transform.position, other.position, Color.red, 1);
			Rigidbody rb;
			rb = Instantiate(loadout[i], other.position, Quaternion.identity).GetComponent<Rigidbody>();
			rb.velocity = dir * force;
		}
	}
}
