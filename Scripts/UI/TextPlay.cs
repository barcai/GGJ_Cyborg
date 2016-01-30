using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextPlay : MonoBehaviour {

	public string[] displayText;
	public GameObject txtObj;
	public GameObject buttons;
	public bool playText = false;

	private Text txt;
	private int index = 0;
	private int selectionIndex = 4;

	// Use this for initialization
	void Start () 
	{
		txt = txtObj.GetComponent<Text>();
		txt.text = "";
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (!txt.text.Equals(displayText[index]) && playText)
		{
			PlayText ();
		}
		if (Input.GetButtonDown ("Submit") && playText)
		{
			if (!txt.text.Equals (displayText[index])) txt.text = displayText[index];
			else {index++; txt.text = "";}
		}
		if (index == selectionIndex) 
		{
			playText = false;
			buttons.SetActive(true);
		}
	}

	void PlayText()
	{
		txt.text += displayText[index].Substring (txt.text.Length, 1);
	}
}
