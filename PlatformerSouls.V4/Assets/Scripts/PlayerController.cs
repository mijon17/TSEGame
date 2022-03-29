using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MovementSpeed = 1f;
    public float JumpForce = 1f;
    bool facingRight = true;
    public bool canMove;


    private Rigidbody2D _rigidbody;

    public Animator animator;

    public bool canInteract;

    public void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    public void Update()
    {
        if(canMove){
            var movement = Input.GetAxis("Horizontal");
            transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;

            animator.SetFloat("Speed", Mathf.Abs(movement));

            //Jump Code
            if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
            {
                _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);

                // animator.SetBool("IsJumping", true);
            }



            if (movement < 0 && facingRight)
            {
                flip();
            }
            else if (movement > 0 && !facingRight)
            {
                flip();
            }
        }
        //Movement Code


    }
    void flip()
    {
        facingRight = !facingRight;
        transform.Rotate(0f, 180f, 0f);

    }
}
