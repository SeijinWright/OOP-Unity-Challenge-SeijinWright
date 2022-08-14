using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownGuy : MonoBehaviour
{
    protected Rigidbody2D rb;
    protected Overseer os;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        os = Overseer.overseer;
    }

    // Update is called once per frame
    protected virtual void LateUpdate()
    {
        rb.position = new Vector2(rb.position.x, rb.position.y - os.enemySpeed * Time.deltaTime);
        Vector2 tmpPos = Camera.main.WorldToScreenPoint(transform.position);

        if (tmpPos.y <= -os.enemyExitDespawnDistance)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D (Collision2D collision)
    {
        if (collision.gameObject.tag == "Bad Guy")
        {
            collision.rigidbody.AddForce((collision.transform.position - transform.position) * os.enemyBumpForce, ForceMode2D.Impulse);
        }
    }
}
