using UnityEngine;

public class ComputerPaddle : Paddle
{
    [SerializeField] Rigidbody2D ball;
    private Vector2 direction;

    private void Update()
    {
        if (ball.velocity.x > 0)
        {
            if (ball.position.y > transform.position.y)
            {
                direction = Vector2.up;
            } else
            {
                direction = Vector2.down;
            }
        } else
        {
            if (transform.position.y > 0)
            {
                direction = Vector2.down;
            } else
            {
                direction = Vector2.up;
            }
        }
    }

    private void FixedUpdate()
    {
        rb2D.AddForce(direction * speed);
    }
}
