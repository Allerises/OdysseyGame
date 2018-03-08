using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootProjectile : MonoBehaviour {

	public AudioClip shootSound;
	public GameObject[] loadout;
	public Transform other;
	public float force, offset;
	public Text UI;

	private float throwSpeed = 2000f;
	private AudioSource source;
	private float volLowRange = .5f;
	private float volHighRange = 1.0f;
	int i;

	void Start () {
		i = 0;
	}

	void Awake () {
		source = GetComponent<AudioSource> ();
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
			float vol = Random.Range (volLowRange, volHighRange);
			source.PlayOneShot (shootSound, vol);
			Debug.DrawLine(transform.position, other.position, Color.red, 1);
			Rigidbody rb;
			rb = Instantiate(loadout[i], other.position, Quaternion.identity).GetComponent<Rigidbody>();
			rb.velocity = dir * force;
		}
	}
}
