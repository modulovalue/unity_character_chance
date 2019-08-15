using UnityEngine;
using System.Collections;

public class anim : MonoBehaviour {

    private Animator animator;

	void Start () {
        animator = GetComponent<Animator>();
    }

    float speed = 1.0f;
    float jumpSpeed = 8f;
    Vector3 move;
    void FixedUpdate() {

        



        if (Input.GetKey("right"))
        {
            animator.SetBool("jumping", false);
            Vector3 theScale = transform.localScale;
            theScale.x = 1;
            transform.localScale = theScale;

            move = new Vector3(30, 0, 0);


            animator.SetFloat("speed", 1f);
        }
        else if (Input.GetKey("left"))
        {
            animator.SetBool("jumping", false);
            Vector3 theScale = transform.localScale;
            theScale.x = -1;
            transform.localScale = theScale;


            move = new Vector3(-30, 0, 0);

            animator.SetFloat("speed", 1f);
        }
        else if (Input.GetKey("space"))
        {
            animator.SetBool("jumping", true);
        }

        
        transform.position += move * speed * Time.deltaTime;
    }
}
