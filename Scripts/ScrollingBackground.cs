using UnityEngine;
using System.Collections;

public class ScrollingBackground : MonoBehaviour {

	public float speed = 0.1f;


	void Update() 
	{
		if (Input.GetAxis("Horizontal") != 0)
		{
			Vector2 offset = new Vector2(-speed * Input.GetAxis("Horizontal"), 0);
			GetComponent<Renderer>().material.mainTextureOffset += offset;
		}	
	}

}
