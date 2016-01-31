using UnityEngine;
using System.Collections;

public class ScrollingBackground : MonoBehaviour {

	public float speed = 0.1f;
	public GameObject player;


	void Update() 
	{
		if (Input.GetAxis("Horizontal") != 0)
		{
			Vector2 offset = new Vector2((-speed * player.GetComponent<Rigidbody2D>().velocity.x), 0);
			GetComponent<Renderer>().material.mainTextureOffset += offset;
		}	
	}

}
