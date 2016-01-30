using UnityEngine;
using System.Collections;

public class CameraStop : MonoBehaviour {

	public GameObject mCamera;
	
	// Update is called once per frame
    void OnTriggerEnter2D(Collider2D obj)
    {
		Debug.Log ("Collided");
		if (obj.tag == "CameraStopper") 
		{
			mCamera.GetComponent<CameraController> ().trackPlayer = false;
			mCamera.GetComponentInChildren<ScrollingBackground>().speed = 0;
		}

    }

	void OnTriggerExit2D(Collider2D obj)
	{
		if (obj.tag == "CameraStopper") 
		{
			mCamera.GetComponent<CameraController> ().trackPlayer = true;
			mCamera.GetComponentInChildren<ScrollingBackground>().speed = -0.001f;
		}
	}
}
