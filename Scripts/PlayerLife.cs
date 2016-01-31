using UnityEngine;
using System.Collections;

public class PlayerLife : MonoBehaviour {

	public float life = 1;
	public GameObject deathImage;
	
	// Update is called once per frame
	void Update () 
	{
		if (life == 0)
		{
			deathImage.SetActive (true);
			GetComponent<PlayerController>().canControl = false;
		}
	}
}
