using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextPlay : MonoBehaviour {

	public string[] displayText;
	public GameObject txtObj;
	public GameObject imageBlack;
	public GameObject container;
	public GameObject audiosrc;
	public bool playText = false;
	public int blackIndex = 5;
	public Font error;

	private Text txt;
	private int index = 0;


	// Use this for initialization
	void Start () 
	{
		txt = txtObj.GetComponent<Text>();
		txt.text = "";
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (index == blackIndex) 
		{
			imageBlack.SetActive(true);
			audiosrc.SetActive(false);
		}
		if (displayText[index] == "")
		{
			imageBlack.GetComponent<SacrificeLimb>().enabled = true;
		}
		if (!txt.text.Equals(displayText[index]) && playText)
		{
			PlayText ();
		}
		if (Input.GetButtonDown ("Submit") && playText)
		{
			if (!txt.text.Equals (displayText[index])) txt.text = displayText[index];
			else {index++; txt.text = "";}
		}
	}

	void PlayText()
	{
		string a = displayText[index].Substring (txt.text.Length, 1);
		if (a == "#")
		{
			txt.font = error;
		}
		txt.text += a;
	}
}
