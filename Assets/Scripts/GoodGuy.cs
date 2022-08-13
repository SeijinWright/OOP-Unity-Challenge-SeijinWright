using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodGuy : MonoBehaviour
{

    public float speed;
    private float horizontalInput;
    private float verticalInput;
    
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
        transform.Translate(movement);
    }
}
