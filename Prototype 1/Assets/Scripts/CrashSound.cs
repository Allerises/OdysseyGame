﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashSound : MonoBehaviour {

	public AudioClip crashSoft;
	public AudioClip crashHard;

	private AudioSource source;
	private float lowPitchRange = .75F;
	private float highPitchRange = 1.5F;
	private float velToVol = .2F;
	private float velocityClipSplit = 2F;

	void Start () {
		source = GetComponent<AudioSource>();
	}

	void OnCollisionEnter (Collision coll) {
		source.pitch = Random.Range (lowPitchRange, highPitchRange);
		float hitVol = coll.relativeVelocity.magnitude * velToVol;
		if (coll.relativeVelocity.magnitude < velocityClipSplit)
			source.PlayOneShot (crashSoft, hitVol);
		else
			source.PlayOneShot (crashHard, hitVol);
	}
}
