using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 10f;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        transform.Translate(Vector2.right * Input.GetAxisRaw("Horizontal") * moveSpeed * Time.fixedDeltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y - 0.51f), Vector2.down, 0.01f))
            {
                rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            }
        }
    }
}
