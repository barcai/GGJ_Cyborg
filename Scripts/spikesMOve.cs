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
            Debug.Log("player touched me!");
            
            Animator anim = GetComponent<Animator>();
            anim.SetBool("isTouchingPlayer", true);
        }
    }

    void OnTrigger2DExit(Collider2D other)
    {
        Debug.Log("something left me!");
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("player left me!");

            Animator anim = GetComponent<Animator>();
            anim.SetBool("isTouchingPlayer", false);
        }
    }
}
