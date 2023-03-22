using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet1 : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();

        if (hitInfo.name == "player1")
        {

        }
        else
        {
            if(hitInfo.name == "Enemy")
            {
                Destroy(hitInfo);

                Destroy(gameObject);


            }
        }
      
    }

   
}
