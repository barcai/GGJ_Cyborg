using UnityEngine;
using System.Collections;

public class AnimationController : MonoBehaviour {


    public Animator animator;

    private PlayerController controller;


    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
        controller = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.onGround && Input.GetButton("Jump"))
        {
            animator.SetBool("JumpButtonPressed", true);
        }
        Debug.Log(animator.GetBool("JumpButtonPressed"));
    }

    void OnCollisionEnter2D(Collision2D obj)
    {
        if (obj.gameObject.tag == "Ground")
        {
            animator.SetBool("JumpButtonPressed", false);
        }
    }
}
