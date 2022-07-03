using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMovement : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
         direction= new Vector2(2f, 2f);
        rb.velocity = direction;// so the ball will start moving to the upper right corner
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = direction;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "padel")
        {
            direction.x = -direction.x;
        }
        else if (collision.gameObject.tag == "border")
        {
            direction.y = -direction.y;
        }
        else {
            rb.transform.position = new Vector2(0, 0);

        }


    }
}
