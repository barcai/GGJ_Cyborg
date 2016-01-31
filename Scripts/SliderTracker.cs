using UnityEngine;
using System.Collections;

public class SliderTracker : MonoBehaviour {

	public GameObject player;

	// Update is called once per frame
	void Update () 
	{
		transform.position = player.transform.position + new Vector3(0, 0.1f, 0);
	}
}
