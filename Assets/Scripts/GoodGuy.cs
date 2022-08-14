using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodGuy : MonoBehaviour
{

    public float speed;
    private float horizontalInput;
    private float verticalInput;
    private Rigidbody2D rb;

    private Overseer os;
    private Animation anim;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        os = Overseer.overseer;
        anim = GetComponent<Animation>();
    }

    void FixedUpdate()
    {
        Move();
    }

    public void Move()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        Vector2 movement;
        movement.x = horizontalInput * speed * Time.deltaTime;
        movement.y = verticalInput * speed * Time.deltaTime;
        rb.velocity = movement;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bad Guy")
        {
            os.AddHit();
            anim.Play("Player Hurt");
        }
    }
}
