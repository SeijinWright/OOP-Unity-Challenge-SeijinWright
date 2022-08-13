using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpGuy : DownGuy
{
    protected override void LateUpdate()
    {
        rb.position = new Vector2(rb.position.x, rb.position.y + speed * Time.deltaTime);
    }
}
