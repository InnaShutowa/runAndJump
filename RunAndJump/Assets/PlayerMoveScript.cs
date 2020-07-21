using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveScript : MonoBehaviour {
    public LayerMask whatIsGround;
    public Transform groundCheck;
    public bool isGrounded;
    public float jumpForce;
    public float speed;
    Rigidbody2D rb;
    public bool isLookingLeft;
    Animator anim;

    void Start() {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update() {
        //проверка, нажат-ли прыжок и находится-ли крыса на земле
        if ((Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Space)) && isGrounded) {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isGrounded = false;
        }
    }

    void FixedUpdate() {
        isGrounded = Physics2D.OverlapPoint(groundCheck.position, whatIsGround);
        float x = Input.GetAxis("Horizontal");
        Vector3 move = new Vector3(x * speed, rb.velocity.y, 0f);
        rb.velocity = move;
        if (x < 0 && !isLookingLeft)
            Turn();

        if (x > 0 && isLookingLeft)
            Turn();
    }

    void Turn() {
        isLookingLeft = !isLookingLeft;
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }

}