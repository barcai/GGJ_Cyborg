using UnityEngine;
using System.Collections;

public class ScrollingTrees : MonoBehaviour {

    public float speed = 0.005f;

    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            Vector3 offset = new Vector3(-speed * Input.GetAxis("Horizontal"), 0, 0);
            transform.position = transform.position + offset;
        }
    }

}
