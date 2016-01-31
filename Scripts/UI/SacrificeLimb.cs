using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SacrificeLimb : MonoBehaviour 
{
	public AudioSource audsrc;
	public AudioClip sword;
	public int level_to_load;

	private bool red = false;

	// Update is called once per frame
	void Update () 
	{
		if (!red)
		{
			GetComponent<Image>().color = Color.red;
			red = true;
			audsrc.PlayOneShot (sword);
		}
		else if (GetComponent<Image>().color.r <= 0)
		{
			StartCoroutine("NextLevel");
		}
		else
		{
			GetComponent<Image>().color -= new Color32(10, 0, 0, 0);
		}
	}

	IEnumerator NextLevel()
	{
		yield return new WaitForSeconds(1);
		Application.LoadLevel(level_to_load);
	}
}
