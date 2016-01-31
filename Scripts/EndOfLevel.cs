using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EndOfLevel : MonoBehaviour {

	public GameObject img;
	
	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D obj)
	{
		if (obj.tag == "Player")
		{
			img.GetComponent<ImageFadeIn>().enabled = true;
		}
	}
}
