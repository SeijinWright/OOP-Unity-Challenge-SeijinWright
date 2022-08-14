using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftGuy : DownGuy
{
    protected override void LateUpdate()
    {
        rb.position = new Vector2(rb.position.x - os.enemySpeed * Time.deltaTime, rb.position.y);
        Vector2 tmpPos = Camera.main.WorldToScreenPoint(transform.position);
        if (tmpPos.x <= -os.enemyExitDespawnDistance)
        {
            Destroy(gameObject);
        }
    }
}
