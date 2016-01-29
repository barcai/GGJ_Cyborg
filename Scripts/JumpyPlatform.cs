﻿using UnityEngine;
using System.Collections;

public class JumpyPlatform : MonoBehaviour {

	public float extra_jump; // number of extra jumps when player arrives on the platform

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Player") {
			Rigidbody2D rb = coll.gameObject.GetComponent<Rigidbody2D>();
			rb.AddForce(new Vector2(Random.Range(10, 50), Random.Range(10, 100)));
			extra_jump--;
		}
	}
}
