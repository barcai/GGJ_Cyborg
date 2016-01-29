using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed = 100;
	public float speedLimit = 30;
	public float jumpHeight = 100;

	private Rigidbody2D rb;
	public bool onGround = true;

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

		// Jumping
		if (onGround && Input.GetButton("Jump"))
		{
			rb.AddForce(new Vector2(0, jumpHeight));
			onGround = false;
		}

		// Braking
		if (Mathf.Abs(Input.GetAxis("Horizontal")) < 0.5)
		{
			rb.velocity = new Vector2(rb.velocity.x * 1/2, rb.velocity.y);
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

	void OnCollisionStay2D(Collision2D obj)
	{
		if (obj.gameObject.tag == "Ground")
		{
			onGround = true;
		}
	}
}
