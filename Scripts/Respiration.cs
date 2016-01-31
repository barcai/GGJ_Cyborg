using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Respiration : MonoBehaviour {

	public float rate = 0.001f;
	public bool depleting = true;
	public Slider sld;
	public GameObject fill;
    public bool hasLungs = true;

	private PlayerLife pl;

	void Start()
	{
		pl = GetComponent<PlayerLife>();
	}

	// Update is called once per frame
	void Update () 
	{
        if (hasLungs)
        {
            Vector2 movement = gameObject.GetComponent<Rigidbody2D>().velocity;

            if (movement.x == 0 && movement.y == 0)
            {
                rate = -0.005f;
            }
            else
            {
                rate = 0.0014f;
            }
        }

		if (depleting)
		{
			sld.value -= rate;
			fill.GetComponent<Image>().color = new Color32(0, 110, 188, 255);
		}

		
		if (sld.value <= 0)
		{
			pl.life = 0;
			depleting = false;
		}
		else if (sld.value < 0.2)
		{
			fill.GetComponent<Image>().color = Color.red;
		}
		else if (sld.value < 0.5)
		{
			fill.GetComponent<Image>().color = Color.yellow;
		}
	}

	void OnTriggerEnter2D(Collider2D obj)
	{
		if (obj.tag == "Respirator")
		{
			rate = -0.005f;
		}
	}

	void OnTriggerExit2D(Collider2D obj)
	{
		if (obj.tag == "Respirator")
		{
			rate = 0.0018f;
		}
	}
}
