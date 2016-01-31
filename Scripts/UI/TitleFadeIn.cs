using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TitleFadeIn : MonoBehaviour {

	public int waitFrames = 0;
	public int level_to_load;
	
	// Update is called once per frame
	void Update () 
	{
		if (Time.frameCount > waitFrames)
		{
			GetComponent<Text>().color += new Color(0,0,0,0.01f);
		}

		if (Input.GetButtonDown ("Submit"))
		{
			Application.LoadLevel(level_to_load);
		}
	}
}
