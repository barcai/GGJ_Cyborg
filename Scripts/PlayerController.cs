using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed = 100;
	public float speedLimit = 30;

	private Rigidbody2D rb;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}


	// Update is called once per frame
	void FixedUpdate () 
	{
		// Basic movement
		Vector2 movement = new Vector2(Input.GetAxis("Horizontal"), 0);
		rb.AddForce(movement * speed);
		// Braking
		if (Mathf.Abs(Input.GetAxis("Horizontal")) < 0.2)
		{
			rb.velocity = rb.velocity * 1/2;
		}
	
		// Max speed
		if (rb.velocity.x > speedLimit)
		{
			rb.velocity = new Vector2(speedLimit, rb.velocity.y);
		}
		else if (rb.velocity.x < -speedLimit)
		{
			rb.velocity = new Vector2(-speedLimit, rb.velocity.y);
		}
	}
}
