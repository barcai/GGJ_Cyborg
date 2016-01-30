using UnityEngine;
using System.Collections;

public class spikesMOve : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Animator anim = GetComponent<Animator>();
            anim.SetBool("isTouchingPlayer", true);
			other.gameObject.GetComponent<PlayerLife>().life = 0;
        }
    }
}
