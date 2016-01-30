using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonSelection : MonoBehaviour {

	public GameObject buttons;
	public GameObject image;

	public void SelectLevel(int level)
	{
		if (level == 1) Application.LoadLevel(level);
		else
		{
			Debug.Log (level.ToString ());
		}
	}
}
