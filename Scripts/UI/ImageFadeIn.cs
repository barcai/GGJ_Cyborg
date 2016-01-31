using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ImageFadeIn : MonoBehaviour {

	public int level_to_load;

	void Update () 
	{
		GetComponent<Image>().color += new Color(0,0,0,0.01f);
		if (GetComponent<Image>().color.a > 0.95)
		{
			Application.LoadLevel(level_to_load);
		}
	}
}
