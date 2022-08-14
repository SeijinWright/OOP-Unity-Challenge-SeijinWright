using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpGuy : DownGuy
{
    protected override void LateUpdate()
    {
        rb.position = new Vector2(rb.position.x, rb.position.y + os.enemySpeed * Time.deltaTime);
        Vector2 tmpPos = Camera.main.WorldToScreenPoint(transform.position);
        if (tmpPos.y >= Camera.main.pixelHeight + os.enemyExitDespawnDistance)
        {
            Destroy(gameObject);
        }
    }
}
