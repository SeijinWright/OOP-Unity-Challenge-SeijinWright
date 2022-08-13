using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownGuy : MonoBehaviour
{
    protected Rigidbody2D rb;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    protected virtual void LateUpdate()
    {
        rb.position = new Vector2(rb.position.x, rb.position.y - speed * Time.deltaTime);
    }
}
