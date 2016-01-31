using UnityEngine;
using System.Collections;

public class ScrollingTrees : MonoBehaviour {

    public float speed = 0.01f;
	public GameObject player;

    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
			Vector3 offset = new Vector3((-speed * player.GetComponent<Rigidbody2D>().velocity.x), 0, 0);
            transform.position = transform.position + offset;
        }
    }

}
