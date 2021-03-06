﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed = 100;
    public Vector2 speedLimit = new Vector2(3, 5);
	public float jumpHeight = 100;
    public float climbPower = 10;
    public float climbLimit = 50;
    public bool canControl = true;
    public bool canClimb = true;
    public bool nearClimableObject = false;
    public bool onGround = true;
	public int playerState = 0; // 0 normal, 1 arms_done, 2 legs_done, 3 lungs_done

	public GameObject mCamera;

	private Rigidbody2D rb;

    void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}


	void FixedUpdate () 
	{
		if (canControl) {
			mCamera.GetComponentInChildren<ScrollingBackground> ().enabled = true;

            // Basic movement
            Vector2 movement = new Vector2(Input.GetAxis("Horizontal"), 0);
            rb.AddForce(movement * speed);
			

			// Jumping
			if (onGround && Input.GetButton ("Jump")) {
				rb.AddForce (new Vector2 (0, jumpHeight));
				onGround = false;
			}
            else if (nearClimableObject && Input.GetButton("Jump")) // Climbing
            {
                if (rb.velocity.y < climbLimit)
                {
                    rb.AddForce(new Vector2(0, climbPower));
                    nearClimableObject = false;
                }
            }

            // Braking
            if (Mathf.Abs (Input.GetAxis ("Horizontal")) < 0.5) {
				rb.velocity = new Vector2 (rb.velocity.x * 1 / 2, rb.velocity.y);
			}
	
			// Max speed
			if (rb.velocity.x > speedLimit.x) {
				rb.velocity = new Vector2 (speedLimit.x, rb.velocity.y);
			} else if (rb.velocity.x < -speedLimit.x) {
				rb.velocity = new Vector2 (-speedLimit.x, rb.velocity.y);
			}
            if (rb.velocity.y > speedLimit.y)
            {
                rb.velocity = new Vector2(rb.velocity.x, speedLimit.y);
            }

            // Kill floor
            if (rb.position.y < -5)
			{
				GetComponent<PlayerLife>().life = 0;
			}
		} 
		else 
		{
			mCamera.GetComponentInChildren<ScrollingBackground>().enabled = false;
		}
	}

	void OnCollisionEnter2D(Collision2D obj)
	{
		if (obj.gameObject.tag == "Ground")
		{
            onGround = true;
		}
	}

    void OnCollisionStay2D(Collision2D obj)
    {
        if (canClimb && obj.gameObject.tag == "Ground")
        {
            nearClimableObject = true;
        }
    }
}
