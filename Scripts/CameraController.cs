using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;
	public bool trackPlayer = true;
	
	// Update is called once per frame
	void Update () 
	{
		if (trackPlayer)
		{
			Vector3 position = new Vector3(player.transform.position.x, 0.4f, -5);
			transform.position = position;
		}
	}
}
