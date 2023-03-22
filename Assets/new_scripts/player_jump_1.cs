using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_jump_1 : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] int jumpPower1;
    [SerializeField] float fallMultiplier1;

    public Transform groundCheck;
    public LayerMask groundLayer;
    bool isGrounded;
    Vector2 vecGravity;

    // Start is called before the first frame update
    void Start()
    {
        vecGravity = new Vector2(0, -Physics2D.gravity.y);
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.OverlapCapsule(groundCheck.position, new Vector2(20.73f, 2.5f), CapsuleDirection2D.Horizontal, 0, groundLayer);
        if (Input.GetKey(KeyCode.UpArrow) && isGrounded)
        {
        
            rb.velocity = new Vector2(rb.velocity.x, jumpPower1);
        }

        if (rb.velocity.y < 0)
        {
            rb.velocity -= vecGravity * fallMultiplier1 * Time.deltaTime;
        }
    }
}
