using UnityEngine;
using System.Collections;

public class AnimationController : MonoBehaviour {


    Animator animator;

    private PlayerController controller;
    private Rigidbody2D rb;
	public GameObject dirLight;


    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
        controller = GetComponent<PlayerController>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.onGround && Input.GetButton("Jump"))
        {
            animator.SetBool("JumpButtonPressed", true);
        }

        if (rb.velocity.x > 0.5)
        {
            if (transform.rotation.y != 0)
            {
                transform.Rotate(new Vector3(0, -180, 0));
				dirLight.transform.Rotate(new Vector3(0, -180, 0));
            }
            animator.SetBool("Moving", true);
        } else if (rb.velocity.x < -0.5)
        {
            if (transform.rotation.y == 0)
            {
				dirLight.transform.Rotate(new Vector3(0, 180, 0));
                transform.Rotate(new Vector3(0, 180, 0));
            }
            animator.SetBool("Moving", true);
        }
        else
        {
            animator.SetBool("Moving", false);
        }

    }

    void OnCollisionEnter2D(Collision2D obj)
    {
        if (obj.gameObject.tag == "Ground")
        {
            animator.SetBool("JumpButtonPressed", false);
        }
    }
}
