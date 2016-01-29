using UnityEngine;
using System.Collections;

public class JumpyPlatform : MonoBehaviour {

	public float extra_jump; // number of extra jumps when player arrives on the platform
	public float xmin = 50;
	public float xmax = 500;
	public float ymin = 50;
	public float ymax = 300;

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Player") {
			Rigidbody2D rb = coll.gameObject.GetComponent<Rigidbody2D>();
			rb.AddForce(new Vector2(Random.Range(xmin, xmax), Random.Range(ymin, ymax)));
			extra_jump--;
		}
	}
}
