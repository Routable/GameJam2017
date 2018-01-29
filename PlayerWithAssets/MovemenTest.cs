using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovemenTest : MonoBehaviour
{

    public float jump = 70000;
    private Rigidbody2D rigi;
    bool grounded = false;
    public Transform groundCheck;
    float groundRadius = 0.02f;
    public LayerMask ground;

    Animator playerAnim;

    private void Start()
    {
        playerAnim = GetComponent<Animator>();
        rigi = GetComponent<Rigidbody2D>();
    }

    public float maxSpeed = 10f;
    bool facingRight = true;

    void FixedUpdate()
    {

        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, ground);

        playerAnim.SetBool("Ground", grounded);

        float move = Input.GetAxis("Horizontal");

        playerAnim.SetFloat("Speed", Mathf.Abs(move));
        rigi.velocity = new Vector2(move * maxSpeed, rigi.velocity.y);

        if (move > 0 && !facingRight)
            FlipDir();
        else if (move < 0 && facingRight)
            FlipDir();


    }

    private void Update()
    {

        playerAnim.SetFloat("verticalSpeed", rigi.velocity.y);


        playerAnim.SetBool("HitFromLeft", false);
        if (WaveCollision.getHit())
        {
            playerAnim.SetBool("HitFromLeft", true);
        }
        if (grounded && Input.GetKeyDown(KeyCode.Space))
        {
            playerAnim.SetBool("Ground", false);
            rigi.AddForce(new Vector2(0, jump));
        }


    }

    void FlipDir()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

}
