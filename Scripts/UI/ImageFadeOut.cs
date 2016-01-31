using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ImageFadeOut : MonoBehaviour {
	
	// Update is called once per frame
	void Update () 
	{
		GetComponent<Image>().color -= new Color(0,0,0,0.01f);
	}
}
