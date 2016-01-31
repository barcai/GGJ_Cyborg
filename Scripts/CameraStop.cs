using UnityEngine;
using System.Collections;

public class CameraStop : MonoBehaviour {

	public GameObject mCamera;
	public GameObject mCanvas;
	
	// Update is called once per frame
    void OnTriggerEnter2D(Collider2D obj)
    {
		if (obj.tag == "CameraStopper") 
		{
			mCamera.GetComponent<CameraController> ().trackPlayer = false;
			mCamera.GetComponentInChildren<ScrollingBackground>().speed = 0;
            mCamera.GetComponentInChildren<ScrollingTrees>().speed = 0;
        }
		else if (obj.tag == "Cutscene")
		{
			GetComponent<PlayerController>().canControl = false;
			GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
			mCanvas.GetComponent<Canvas>().enabled = true;
			mCanvas.GetComponent<Canvas>().GetComponent<TextPlay>().playText = true;
		}

    }

	void OnTriggerExit2D(Collider2D obj)
	{
		if (obj.tag == "CameraStopper") 
		{
			mCamera.GetComponent<CameraController> ().trackPlayer = true;
			mCamera.GetComponentInChildren<ScrollingBackground>().speed = -0.0005f;
            mCamera.GetComponentInChildren<ScrollingTrees>().speed = 0.01f;
        }
	}
}
