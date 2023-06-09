using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_horizontalcontrol : MonoBehaviour
{
    Vector2 move;
    public int speed;


    Rigidbody2D rb;

    private bool facingRight = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxisRaw("Vertical"));
        
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(move.x * speed, rb.velocity.y);

        if( rb.velocity.x < 0 && facingRight )
        {
            Flip();
        }
        else if( rb.velocity.x > 0 && !facingRight)
        {
            Flip();
        }
    }

    private void Flip()
    {
        facingRight = !facingRight;
        transform.Rotate(0f, 180f, 0f);
    }
}
