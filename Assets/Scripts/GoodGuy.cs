using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodGuy : MonoBehaviour
{

    public float speed;
    private float horizontalInput;
    private float verticalInput;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Move();
        Vector2 tmpPos = Camera.main.WorldToScreenPoint(transform.position);
        print(tmpPos.x + " " + tmpPos.y);
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
}
