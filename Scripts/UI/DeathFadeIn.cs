using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DeathFadeIn : MonoBehaviour {
	
	private int frameBuffer;
	public Text died;
	
	// Update is called once per frame
	void Update () 
	{
		GetComponent<Image>().color += new Color(0,0,0,0.01f);
		died.GetComponent<Text>().color += new Color(0,0,0,0.01f);

		if (GetComponent<Image>().color.a >= 1 && Input.GetButtonDown ("Submit"))
		{
			int a = Application.loadedLevel;
			Application.LoadLevel(a);
		}
	}
}
