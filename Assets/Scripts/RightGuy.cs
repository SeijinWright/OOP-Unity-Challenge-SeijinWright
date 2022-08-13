using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightGuy : DownGuy
{
    protected override void LateUpdate()
    {
        rb.position = new Vector2(rb.position.x + speed * Time.deltaTime, rb.position.y);
    }
}
