using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float jump_speed;
    public static float movement;
    new Rigidbody2D rigidbody;
    public Transform groundcheckPoint;
    public float radius;
    public LayerMask groundlayer;
    bool isTouchingground;
    public static bool isfacingRight = true;
    Animator anim;




    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }


    // Update is called once per frame
    void Update()
    {
        isTouchingground = Physics2D.OverlapCircle(groundcheckPoint.position, radius, groundlayer);
        movement = Input.GetAxis("Horizontal");
        if (movement < 0f)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
            isfacingRight = false;
        }
        else if (movement > 0f)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
            isfacingRight = true;
        }
        rigidbody.velocity = new Vector2(speed * movement, rigidbody.velocity.y);
        if (Input.GetButtonDown("Jump") && isTouchingground)
        {
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, jump_speed);
            Sound.PlaySound("jump");
        }


        anim.SetFloat("Movement", Mathf.Abs(rigidbody.velocity.x));
        anim.SetBool("onGround", isTouchingground);

    }

}
