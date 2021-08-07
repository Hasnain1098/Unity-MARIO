using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AINinja : MonoBehaviour
{
    new Rigidbody2D rigidbody;
    float speed = 3f, movementDirX, range = 6f, distToPlayer, minX = -10, maxX = 10;
    Vector2 localScale;
    public static bool isAttacking = false;

    public Transform player;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        movementDirX = 1f;
        rigidbody = GetComponent<Rigidbody2D>();
        localScale = transform.localScale;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        distToPlayer = Vector2.Distance(transform.position, player.position);
        if (distToPlayer <= range)
        {
            ChasePlayer();

        }
        else
        {
            rigidbody.velocity = Vector2.zero;
            anim.SetFloat("Movement", rigidbody.velocity.x);
        }
       /* if (isAttacking)
        {
            anim.SetBool("isAttacking", true);
        }
        else
            anim.SetBool("isAttacking", false);*/
    }


    void ChasePlayer()
    {
        if (transform.position.x < player.position.x && PlayerController.movement != 0f)
        {
            Debug.Log("Ninja on the left side");
            rigidbody.velocity = new Vector2(movementDirX * speed, 0);
            transform.localScale = new Vector2(localScale.x, localScale.y);

        }
        else if (transform.position.x < minX)
        {
            rigidbody.velocity = new Vector2(movementDirX * speed, 0);
            rigidbody.velocity = new Vector2(localScale.x, localScale.y);

        }
        else if (transform.position.x > maxX)
        {
            rigidbody.velocity = new Vector2(-movementDirX * speed, 0);
            rigidbody.velocity = new Vector2(-localScale.x, localScale.y);
        }
        else if (transform.position.x > player.position.x && PlayerController.movement != 0f)
        {
            rigidbody.velocity = new Vector2(-movementDirX * speed, 0);
            transform.localScale = new Vector2(-localScale.x, localScale.y);

        }
        anim.SetFloat("Movement", speed);



    }

}










